import os.path
from BL import MUser

class MUserUI:
    @staticmethod
    def menu():
        print("1. Sign In")
        print("2. Sign Up")
        print("3. Exit")
        print("\n Enter your option: ")
        option = int(input())
        return option
    
    @staticmethod
    def printList(usersList):
        for user in usersList:
            print(user.userName, user.userPassword, user.userRole)

    @staticmethod
    def TakeInputFromConsole():
        userName = input("Enter Username: ")
        userPassword = input("Enter Password: ")
        userRole = input("Enter Role: ")
        user = MUser(userName, userPassword, userRole)
        return user
    
    @staticmethod
    def TakeInputWithoutRole():
        userName = input("Enter Username: ")
        userPassword = input("Enter Password: ")
        user = MUser(userName, userPassword, None)
        return user