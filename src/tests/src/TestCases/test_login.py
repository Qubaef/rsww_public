from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement

import src.config as config
import src.utils as utils
from src.TestCases.test_case import TestCase


class LoginTestCase(TestCase):
    def __init__(self):
        super().__init__("LoginTestCase")

    def run(self, driver: webdriver) -> bool:
        print(f"{self.name}: Starting test...")
        driver.get(config.URL)

        # Find and click login button
        button_goto_login: WebElement = utils.wait_for_xpath(driver, config.GOTO_LOGIN_XPATH, 3)
        if button_goto_login is None:
            print(f"{self.name}: Login button not found")
            return False
        button_goto_login.click()

        # Wait until login form is loaded using visibilityOfElementLocated
        button_send_login: WebElement = utils.wait_for_xpath(driver, config.LOGIN_BUTTON_XPATH, 3)
        if button_send_login is None:
            print(f"{self.name}: Login form not found")
            return False

        # Find and fill login form
        input_login = driver.find_element_by_id("loginInput")
        if input_login is None:
            print(f"{self.name}: loginInput form not found")
            return False
        input_login.send_keys(config.USERNAME)

        input_password = driver.find_element_by_id("passInput")
        if input_password is None:
            print(f"{self.name}: passInput form not found")
            return False
        input_password.send_keys(config.PASSWORD)

        # Click login button
        button_send_login.click()

        # Verify if logout button is visible
        button_send_logout: WebElement = utils.wait_for_xpath(driver, config.LOGOUT_BUTTON_XPATH, 3)
        if button_send_logout is None:
            print(f"{self.name}: Failed to log in")
            return False

        return True
