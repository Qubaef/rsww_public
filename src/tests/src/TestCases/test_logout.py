from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement

import src.config as config
import src.utils as utils
from src.TestCases.test_case import TestCase


class LogoutTestCase(TestCase):
    def __init__(self):
        super().__init__("LogoutTestCase")

    def run(self, driver: webdriver) -> bool:
        print(f"{self.name}: Starting test...")
        driver.get(config.URL)

        # Find and click login button
        button_logout: WebElement = utils.wait_for_xpath(driver, config.LOGOUT_BUTTON_XPATH, 3)
        if button_logout is None:
            print(f"{self.name}: Logout button not found")
            return False
        button_logout.click()

        # Verify if login button is visible
        button_login: WebElement = utils.wait_for_xpath(driver, config.GOTO_LOGIN_XPATH, 3)
        if button_login is None:
            print(f"{self.name}: Failed to log in")
            return False

        return True
