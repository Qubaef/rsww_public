from abc import ABC
from selenium import webdriver


class TestCase(ABC):
    def __init__(self, name):
        self.name = name

    def run(self, driver: webdriver) -> bool:
        raise NotImplementedError
