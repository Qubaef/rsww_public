from typing import List
from selenium import webdriver

from colorama import Fore
from colorama import Style

import src.utils as utils
from src.TestCases.test_book_first_offer import BookFirstOfferTestCase
from src.TestCases.test_buy_offer import BuyOfferTestCase
from src.TestCases.test_buy_offer_wrong_pin import BuyOfferWrongPinTestCase
from src.TestCases.test_login import LoginTestCase
from src.TestCases.test_logout import LogoutTestCase
from src.TestCases.test_find_offers import FindOffersTestCase

from src.TestCases.test_case import TestCase


def run_test(driver: webdriver, test_case: TestCase):
    res = test_case.run(driver)
    if res:
        print(f"{Fore.GREEN}{test_case.name} : Test passed{Style.RESET_ALL}")
    else:
        print(f"{Fore.RED}{test_case.name} : Test failed{Style.RESET_ALL}")


def run_tests():
    driver = utils.get_chrome_webdriver()

    # Tests
    tests: List[TestCase] = [
        # Order with correct pin
        LoginTestCase(),
        FindOffersTestCase(),
        BookFirstOfferTestCase(),
        BuyOfferTestCase(),
        LogoutTestCase(),

        # Order with incorrect pin
        LoginTestCase(),
        FindOffersTestCase(),
        BookFirstOfferTestCase(),
        BuyOfferWrongPinTestCase(),
        LogoutTestCase()
    ]

    # Run tests
    for test in tests:
        run_test(driver, test)

    driver.close()


if __name__ == "__main__":
    run_tests()
