from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement

import src.config as config
import src.utils as utils
from src.TestCases.test_case import TestCase


class BuyOfferTestCase(TestCase):
    def __init__(self):
        super().__init__("BuyOfferTestCase")

    def run(self, driver: webdriver) -> bool:
        print(f"{self.name}: Starting test...")

        # Fill correct pin
        pin_form = utils.wait_for_xpath(driver, config.PIN_FORM_XPATH, 3)
        if pin_form is None:
            print(f"{self.name}: pint form not found")
            return False
        pin_form.clear()
        pin_form.send_keys(config.CORRECT_PINT)

        # If buy button on redirected page exists
        buy_button = utils.wait_for_xpath(driver, config.BUY_BUTTON_XPATH, 3)
        if buy_button is None:
            print(f"{self.name}: buy button not found")
            return False
        buy_button.click()

        # Wait for first notification to appear
        notification = utils.wait_for_xpath(driver, "//div[contains(@id,'notification')]", 4)
        if notification is None:
            print(f"{self.name}: notification not found")
            return False

        # Get text of paragraph by xpath
        try:
            text = driver.find_element_by_xpath(config.NOTIFICATION_TEXT_XPATH).text
        except:
            print(f"{self.name}: wrong notification xpath")
            return False
        if text != config.EXPECTED_BUY_TEXT:
            print(f"{self.name}: payment failed or incorrect notification text")
            return False

        return True
