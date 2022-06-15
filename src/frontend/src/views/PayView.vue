<template>
  <el-form ref="ruleFormRef" :model="form" :rules="rules">
    <el-form-item
      label="Please provide your card number (16 digits):"
      prop="cardNum"
    >
      <el-input v-model="form.cardNum" />
    </el-form-item>
    <el-form-item>
      <el-button
        type="primary"
        @click="submitForm(ruleFormRef)"
        :loading="submitting"
        >Buy</el-button
      >
    </el-form-item>
  </el-form>
</template>

<script lang="ts">
import { purchaseOffer } from "@/utils/requests";
import type { FormInstance } from "element-plus";
import { defineComponent, reactive, ref, h } from "vue";
import { ElNotification } from "element-plus";

export default defineComponent({
  props: {
    offerId: {
      type: String,
      required: true,
    },
  },
  setup(props) {
    const ruleFormRef = ref<FormInstance>();

    const form = reactive({
      cardNum: "1234567890123456",
    });

    const submitting = ref(false);

    const validateCardNum = (rule: any, value: string, callback: any) => {
      if (value === "") {
        callback(new Error("Please input card number"));
      } else if (value.length !== 16) {
        callback(new Error("Card numver must be 16 digits."));
      } else if (!/^\d+$/.test(value)) {
        callback(new Error("Card numver must be 16 digits."));
      } else {
        callback();
      }
    };

    const rules = reactive({
      cardNum: [{ validator: validateCardNum, trigger: "blur" }],
    });

    const confirmPayment = () => {
      console.log("purchasing");
      submitting.value = true;
      purchaseOffer({
        cardNumber: form.cardNum,
        orderId: props.offerId,
      })
        .then((res) => {
          if (res) {
            ElNotification({
              title: "Success",
              message: "Payment ok! Have a great holiday!",
              type: "success",
            });
          } else {
            ElNotification({
              title: "Error",
              message: "Something went wrong.",
              type: "error",
            });
          }
          submitting.value = false;
        })
        .catch(() => {
          ElNotification({
            title: "Error",
            message: "Something went wrong.",
            type: "error",
          });
          submitting.value = false;
        });
    };

    const submitForm = (formEl: FormInstance | undefined) => {
      if (!formEl) return;
      formEl.validate((valid) => {
        if (valid) {
          confirmPayment();
        } else {
          return false;
        }
      });
    };

    return { ruleFormRef, form, rules, submitForm, submitting };
  },
});
</script>
