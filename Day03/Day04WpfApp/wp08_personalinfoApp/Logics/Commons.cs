﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wp08_personalinfoApp.Logics
{
    internal class Commons
    {
        public static bool IsValidEmail(string email)
        {
            // Regular Expression 정규표현식
            var strPattern = @"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$";
            // 이메일 형식에 맞게 입력하도록 검증
            return Regex.IsMatch(email, strPattern); // 
        }
        public static int GetAge(DateTime value)
        {
            // 입력된 날짜로 나이를 계산
            int result;
            if (DateTime.Now.Month < value.Month || DateTime.Now.Month == value.Month &&
                DateTime.Now.Day < value.Day)
            {
                result = DateTime.Now.Year - value.Year -1; // 아직 생일이 지나지 않음
            }
            else
            {
                result = DateTime.Now.Year - value.Year;
            }
            return result;
        }
        public static string GetZodiac(DateTime value)
        {
            int reminder = value.Year % 12;
            switch (reminder)
            {
                // 입력된 생일로 12지신 리턴
                case 4:
                    return "쥐띠";
                case 5:
                    return "소띠";
                case 6:
                    return "호랑이띠";
                case 7:
                    return "토끼띠";
                case 8:
                    return "용띠";
                case 9:
                    return "뱀띠";
                case 10:
                    return "말띠";
                case 11:
                    return "양띠";
                case 0:
                    return "원숭이띠";
                case 1:
                    return "닭띠";
                case 2:
                    return "개띠";
                case 3:
                    return "돼지띠";
                default:
                    return "없음";
            }
        }
    }
}
    