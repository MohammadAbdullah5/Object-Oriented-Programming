import os.path
from BL import MUser
class MUserDL:
    usersList = []

    @staticmethod
    def addUserInList(user):
        MUserDL.usersList.append(user)

    @staticmethod
    def signIn(user):
        for storedUser in MUserDL.usersList:
            if(storedUser.userName == user.userName and storedUser.userPassword == user.userPassword):
                return storedUser
        return None
    
    @staticmethod
    def parseData(line):
        line = line.split(',')
        return line
    
    @staticmethod
    def readDataFromFile(path):
        if(os.path.exists(path)):
            fileVariable = open(path, 'r')
            records = fileVariable.read().split("\n")
            fileVariable.close()
            for line in records:
                list = MUserDL.parseData(line)
                username = list[0]
                userPassword = list[1]
                userRole = list[2]
                user = MUser(username, userPassword, userRole)
                MUserDL.addUserInList(user)
            return True
        else:
            return False
        
    @staticmethod
    def storeInFile(user, path):
        file = open(path, 'a')
        file.write("\n" + user.userName + "," + user.userPassword + "," + user.userRole)
        file.close()
    