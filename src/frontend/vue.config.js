const { defineConfig } = require("@vue/cli-service");

module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    proxy: {
      "^/api": {
        target: "http://localhost:82",
        changeOrigin: true,
        secure: false,
        pathRewrite: { "^/api": "" },
        logLevel: "debug",
      },
    },
  },
});
