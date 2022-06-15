from selenium import webdriver
from selenium.webdriver.remote.webelement import WebElement
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.support import expected_conditions as ec
from selenium.webdriver.common.by import By


def get_chrome_webdriver() -> webdriver:
    import chromedriver_autoinstaller
    chromedriver_autoinstaller.install()
    return webdriver.Chrome()


def wait_for_xpath(driver: webdriver, xpath: str, timeout: int) -> WebElement:
    try:
        element = WebDriverWait(driver, timeout).until(
            ec.visibility_of_element_located((By.XPATH, xpath)))
    except:
        return None

    return element
