﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmmerceAPIHCMUE.Provider
{
    public class Constants
    {
        private static Constants instance;
        public static Constants Instance
        {
            get
            {
                if (instance == null) instance = new Constants();
                return Constants.instance;
            }
        }
        private Constants() { }
        // Bấm CTR + R + E để đóng gói
        private int sUCCESS_CODE = 1;
        private int fAIL_CODE = 0;
        private string bAD_REQUEST = "BAD_REQUEST!";
        private string sESSION_EXPIRED = "SESSION_EXPIRED";
        private string uSER_NOT_AUTHENTICATED = "USER_NOT_AUTHENTICATED!";
        private string sOMETHING_WAS_WRONG = "SOMETHING_WAS_WRONG!";
        private string nO_DATA = "NO_DATA";
        private string LOGIN_SUCCESS = "LOGIN_SUCCESS";
        private string LOGIN_FAIL = "LOGIN_FAIL";
        private string SUCCESS_MESSAGE = "SUCCESS!";
        private string FAIL_MESSAGE = "FAIL_MESSAGE";
        private string mySecret = "asdv234234^&%&^%&^hjsdfb2%%%";
        private string myIssuer = "huuvan";
        private string myAudience = "CNTTD";
        private string EMAIL_NOT_EXIST = "EMAIL_NOT_EXIST";
        private string ADD_SUCESS = "ADD_SUCESS";
        private string DELETE_SUCESS = "DELETE_SUCESS";
        private string UPDATE_SUCESS = "UPDATE_SUCESS";
        private string UPDATE_FAIL = "UPDATE_FAIL";
        private string RESET_PASSWORD_FAIL = "RESET_PASSWORD_FAIL";
        private int ADMIN_ROLE = 1;
        private int USER_ROLE = 2;
        private string ClientID = "814891624345-k275c9gvb6nb1fn1qihrqrnrvb8nq8vr.apps.googleusercontent.com";
        private string ClientSecret = "AL7woG1O9n5hHEGsjpAHMKac";
        private string a = "1";
        private int INITIAL_STT = 0;
        private int RECEIVE_STT = 1;
        private int DELIVERY_STT = 2;
        private int COMPLETE_STT = 3;
        //đóng gói: Ctr + R + e 
        public int SUCCESS_CODE { get => sUCCESS_CODE; }
        public int FAIL_CODE { get => fAIL_CODE;  }
        public string BAD_REQUEST { get => bAD_REQUEST; }
        public string SESSION_EXPIRED { get => sESSION_EXPIRED;  }
        public string USER_NOT_AUTHENTICATED { get => uSER_NOT_AUTHENTICATED; }
        public string SOMETHING_WAS_WRONG { get => sOMETHING_WAS_WRONG; }
        public string NO_DATA { get => nO_DATA;}
        public string LOGIN_FAIL1 { get => LOGIN_FAIL; set => LOGIN_FAIL = value; }
        public string LOGIN_SUCCESS1 { get => LOGIN_SUCCESS; set => LOGIN_SUCCESS = value; }
        public string SUCCESS_MESSAGE1 { get => SUCCESS_MESSAGE; set => SUCCESS_MESSAGE = value; }
        public string FAIL_MESSAGE1 { get => FAIL_MESSAGE; set => FAIL_MESSAGE = value; }
        public string MySecret { get => mySecret; }
        public string MyIssuer { get => myIssuer;}
        public string MyAudience { get => myAudience; }
        public string EMAIL_NOT_EXIST1 { get => EMAIL_NOT_EXIST; }
        public string UPDATE_SUCESS1 { get => UPDATE_SUCESS;}
        public string UPDATE_FAIL1 { get => UPDATE_FAIL; }
        public string RESET_PASSWORD_FAIL1 { get => RESET_PASSWORD_FAIL;}
        public int ADMIN_ROLE1 { get => ADMIN_ROLE; }
        public int USER_ROLE1 { get => USER_ROLE; }
        public string ClientID1 { get => ClientID;  }
        public string ClientSecret1 { get => ClientSecret; }
        public string A { get => a;  }
        public string ADD_SUCESS1 { get => ADD_SUCESS;}
        public string DELETE_SUCESS1 { get => DELETE_SUCESS;  }
        public int INITIAL_STT1 { get => INITIAL_STT; set => INITIAL_STT = value; }
        public int RECEIVE_STT1 { get => RECEIVE_STT; set => RECEIVE_STT = value; }
        public int DELIVERY_STT1 { get => DELIVERY_STT; set => DELIVERY_STT = value; }
        public int COMPLETE_STT1 { get => COMPLETE_STT; set => COMPLETE_STT = value; }
    }
}
