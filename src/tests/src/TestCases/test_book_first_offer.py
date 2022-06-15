from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement

import src.config as config
import src.utils as utils
from src.TestCases.test_case import TestCase


class BookFirstOfferTestCase(TestCase):
    def __init__(self):
        super().__init__("BookFirstOfferTestCase")

    def run(self, driver: webdriver) -> bool:
        print(f"{self.name}: Starting test...")

        first_offer_div = utils.wait_for_xpath(driver, config.FIRST_OFFER_DIV_XPATH, 3)
        if first_offer_div is None:
            print(f"{self.name}: first offer not found")
            return False

        # Read offer

        first_button_book = utils.wait_for_xpath(driver, config.FIRST_BOOK_BUTTON_XPATH, 3)
        if first_button_book is None:
            print(f"{self.name}: first book button not found")
            return False
        first_button_book.click()

        # If buy button on redirected page exists
        buy_button = utils.wait_for_xpath(driver, config.BUY_BUTTON_XPATH, 3)
        if buy_button is None:
            print(f"{self.name}: buy button not found")
            return False

        return True
