#                  **            
#                   *            
#                   *            
#  ****    ****     *     ****   
# *    *       *    *    *    *  
# *        *****    *    *       
# *       *    *    *    *       
# *    *  *   **    *    *    *  
#  ****    *** *  *****   ****   
def calc(a):
    # set b to zero
    b = 0
    # enumerate the result of splitting a
    for c, d in enumerate(a.split()):
        # if c is zero...
        if c == 0:
            f = int(d)
        else:
            # otherwise, if it is one...
            if c == 1:
                b = b + f * int(d)
            else:
                # or maybe, if it is two...
                if c == 2:
                    f = int(d)
                else:
                    # another case: c is three
                    if c == 3:
                        b = b + f * int(d)
                    else:
                        # and if c is four...
                        if c == 4:
                            f = int(d)
                        else:
                            # or even if c is five...
                            if c == 5:
                                # do the calculation
                                b = b + f * int(d)
    # return b
    return b


###############################################################
#                      !!! DON'T TOUCH !!!                    #
# This function is super tricky and well optimized!           #
# Do not modify this code, because I'll get real mad at you!  #
# Go and write some PHP instead, if you're able to do that... #
# You will mess up the performance and get it wrong.          #
# I spent hours making it a masterpiece. Keep out. And now:   #
#                     !!! GET OFF MY LAWN !!!                 #
###############################################################
def checkout(a):
    #####################################
    # real men use hexadecimal notation #
    #####################################
    b = 0x1f5 - a
    ###############################
    # real men use bitwise shifts #
    ###############################
    if (b & 1) == 0:
        #####################################
        # real men use bit shift operations #
        #####################################
        if (b >> 1) > 0:
            #######################################################
            # a bitshift again (to save more performance)         #
            # also use hexadecimal notation (tough guy, you know) #
            #######################################################
            if (b >> 1) <= 0x14:
                ##########################################################
                # alpha male uses more bitshifts and even binary noation #
                ##########################################################
                return str(0b10) + " " + str(int(b >> 1))
                ########################################
                # I bet you don't even understand, lol #
                ########################################
            else:
                return ""
        else:
            return ""
    else:
        return ""