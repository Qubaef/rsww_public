URL = "http://localhost:8080/"

USERNAME = "1"
PASSWORD = "1"

# Offer search form
DESTINATION = "Zanzibar"
DEPARTURE = "Gdansk"
ADULTS_COUNT = "2"
CHILDREN_3_COUNT = "0"
CHILDREN_10_COUNT = "0"
CHILDREN_18_COUNT = "0"

CORRECT_PINT = "2222222222222222"
INCORRECT_PIN = "2222222222222221"

EXPECTED_BUY_TEXT = "Payment ok! Have a great holiday!"
EXPECTED_BUY_ERROR_TEXT = "Something went wrong."

# Elements XPATHs
GOTO_LOGIN_XPATH = "//a[text()='Log in']"

LOGIN_BUTTON_XPATH = "//button[text()='Log in']"
LOGOUT_BUTTON_XPATH = "//button[text()='Log out']"

DESTINATION_FORM_XPATH = "/html/body/div[1]/div/div[1]/div[1]/div[1]/div/div/div/div/input"
DESTINATION_DROPDOWN_ELEM_XPATH = f"//div[@aria-hidden='false']/div/div/div/ul/li/span[text()='{DESTINATION}']"
DEPARTURE_FORM_XPATH = "/html/body/div[1]/div/div[1]/div[1]/div[2]/div/div/div/div/input"
DEPARTURE_DROPDOWN_ELEM_XPATH = f"//div[@aria-hidden='false']/div/div/div/ul/li/span[text()='{DEPARTURE}']"
ADULTS_COUNT_FORM_XPATH = "//input[@id='adultsNumberInput']"
CHILDREN_3_COUNT_FORM_XPATH = "//input[@id='childrenTo3NumberInput']"
CHILDREN_10_COUNT_FORM_XPATH = "//input[@id='childrenTo10NumberInput']"
CHILDREN_18_COUNT_FORM_XPATH = "//input[@id='childrenTo18NumberInput']"
SEARCH_BUTTON_XPATH = "/html/body/div/div/div[1]/div[1]/button"

FIRST_OFFER_DIV_XPATH = "/html/body/div[1]/div/div[2]/div[1]"
FIRST_BOOK_BUTTON_XPATH = "/html/body/div/div/div[2]/div[1]/div[3]/div[2]/button"

PIN_FORM_XPATH = "/html/body/div/form/div[1]/div/div/div/input"
BUY_BUTTON_XPATH = "/html/body/div/form/div[2]/div/button"

NOTIFICATION_XPATH = "//div[contains(@id,'notification')]"
NOTIFICATION_TEXT_XPATH = "/html/body/div[3]/div/div/p"

