from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement

import src.config as config
import src.utils as utils
from src.TestCases.test_case import TestCase


class FindOffersTestCase(TestCase):
    def __init__(self):
        super().__init__("FindOffersTestCase")

    def run(self, driver: webdriver) -> bool:
        print(f"{self.name}: Starting test...")
        driver.get(config.URL)

        # Fill destination
        form_destination = utils.wait_for_xpath(driver, config.DESTINATION_FORM_XPATH, 3)
        if form_destination is None:
            print(f"{self.name}: destination form not found")
            return False
        form_destination.click()

        import time
        time.sleep(0.4)

        destination_dropdown_elem = utils.wait_for_xpath(driver, config.DESTINATION_DROPDOWN_ELEM_XPATH, 3)
        if destination_dropdown_elem is None:
            print(f"{self.name}: destination dropdown element not found")
            return False
        destination_dropdown_elem.click()

        # Fill departure
        form_departure = utils.wait_for_xpath(driver, config.DEPARTURE_FORM_XPATH, 3)
        if form_departure is None:
            print(f"{self.name}: departure form not found")
            return False
        form_departure.click()

        import time
        time.sleep(0.4)

        departure_dropdown_elem = utils.wait_for_xpath(driver, config.DEPARTURE_DROPDOWN_ELEM_XPATH, 3)
        if departure_dropdown_elem is None:
            print(f"{self.name}: departure dropdown element not found")
            return False
        departure_dropdown_elem.click()


        adults_count_departure = utils.wait_for_xpath(driver, config.ADULTS_COUNT_FORM_XPATH, 3)
        if adults_count_departure is None:
            print(f"{self.name}: adults form not found")
            return False
        adults_count_departure.clear()
        adults_count_departure.send_keys(config.ADULTS_COUNT)

        children_3_count_departure = utils.wait_for_xpath(driver, config.CHILDREN_3_COUNT_FORM_XPATH, 3)
        if children_3_count_departure is None:
            print(f"{self.name}: children_3 form not found")
            return False
        children_3_count_departure.clear()
        children_3_count_departure.send_keys(config.CHILDREN_3_COUNT)

        children_10_count_departure = utils.wait_for_xpath(driver, config.CHILDREN_10_COUNT_FORM_XPATH, 3)
        if children_10_count_departure is None:
            print(f"{self.name}: children_10 form not found")
            return False
        children_10_count_departure.clear()
        children_10_count_departure.send_keys(config.CHILDREN_10_COUNT)

        children_18_count_departure = utils.wait_for_xpath(driver, config.CHILDREN_18_COUNT_FORM_XPATH, 3)
        if children_18_count_departure is None:
            print(f"{self.name}: children_18 form not found")
            return False
        children_18_count_departure.clear()
        children_18_count_departure.send_keys(config.CHILDREN_18_COUNT)

        button_send_search: WebElement = utils.wait_for_xpath(driver, config.SEARCH_BUTTON_XPATH, 3)
        if button_send_search is None:
            print(f"{self.name}: search button not found")
            return False
        button_send_search.click()

        # Verify if offers were displayed
        first_offer_div = utils.wait_for_xpath(driver, config.FIRST_OFFER_DIV_XPATH, 10)
        if first_offer_div is None:
            print(f"{self.name}: offers not found")
            return False

        return True
