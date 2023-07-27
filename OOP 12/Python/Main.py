from UI import MUserUI
from DL import MUserDL
import os.path
from time import sleep

@staticmethod
def main():
    path = "Data.txt"
    MUserDL.readDataFromFile(path)
    option = 0
    while(option != 3):
        os.system("cls")
        option = MUserUI.menu()
        if(option == 1):
            user = MUserUI.TakeInputWithoutRole()
            user = MUserDL.signIn(user)

            if(user != None):
                if(user.isAdmin()):
                    print("This is Admin !!!")
                else:
                    print("This is User !!!")
                sleep(3)

        elif(option == 2):
            user = MUserUI.TakeInputFromConsole()
            MUserDL.addUserInList(user)
            MUserDL.storeInFile(user, path)

        else:
            break
main()