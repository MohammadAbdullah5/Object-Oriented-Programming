class MUser:
    userName = ""
    userPassword = ""
    userRole = ""

    def __init__(self, username, password, role):
        self.username = username
        self.userPassword = password
        self.userRole = role

    def isAdmin(self):
        if (self.userRole == "Admin"):
            return True
        else:
            return False
