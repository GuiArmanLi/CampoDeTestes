package com.example.email.Utils;

import com.twilio.Twilio;
import com.twilio.rest.api.v2010.account.Message;
import com.twilio.type.PhoneNumber;

public class Email {
    // and set the environment variables. See http://twil.io/secure
    public static final String ACCOUNT_SID = System.getenv("");
    public static final String AUTH_TOKEN = System.getenv("");

    public static void main(String[] args) {
        Twilio.setAccountSid(ACCOUNT_SID);

        Twilio.init(ACCOUNT_SID, AUTH_TOKEN);
        Message message = Message.creator(
                new com.twilio.type.PhoneNumber("+5511946867628"),
                new com.twilio.type.PhoneNumber("+5511976871212"),
                "Primeiro teste!")
                .create();

        message.getSid();
    }
}