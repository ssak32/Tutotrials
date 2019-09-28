import logging

logging.basicConfig(filename="mylogs.log", level=logging.ERROR)
logging.critical("Critical")
logging.error("Error")
logging.warning("Warning")
logging.info("Info")
logging.debug("Debug")
