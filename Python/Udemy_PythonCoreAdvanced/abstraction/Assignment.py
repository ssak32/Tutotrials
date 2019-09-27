from abc import ABC, abstractmethod


class TouchScreenLaptop(ABC):  # TouchScreenLaptop Interface

    @abstractmethod
    def scroll(self):
        pass

    @abstractmethod
    def click(self):
        pass


class HP(TouchScreenLaptop):

    def scroll(self):
        print("HP - Scroll")

    @abstractmethod
    def click(self):
        pass


class DELL(TouchScreenLaptop, ABC):

    def scroll(self):
        print("DELL - Scroll")

    @abstractmethod
    def click(self):
        pass


class HPNotebook(HP):

    def click(self):
        print("HPNotebook - Click")


class DELLNotebook(DELL):

    def click(self):
        print("DELLNotebook - Click")


dnb = DELLNotebook()
dnb.scroll()
dnb.click()

hpnb = HPNotebook()
hpnb.scroll()
hpnb.click()
