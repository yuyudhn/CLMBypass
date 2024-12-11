# AppLocker and CLM Bypass
I created this tool as part of my learning journey for PEN-300. Basically, this tool bypasses AppLocker Policy using installutil.exe and circumvents PowerShell Constrained Language Mode by leveraging a custom Runspace.

References:
- https://lolbas-project.github.io/lolbas/Binaries/Installutil/#execute

It bypasses Defender and other antivirus software (for now).
- https://kleenscan.com/scan_result/645f5626b5b707456e7315f67aa8e5846a55b937a03cc1805aa636faf8a05557
- https://websec.net/scanner/result/3c7a31ce-60e1-459c-9e57-61717af64065

![](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgq-fN6SnJM2RRqW0Yk4kv9ahiMmAjexhhGPMxajSPOtLKXy-0b7jJMiY-ZA7g0k9ZZveTBUm0RCpX9pqO31HqlrgDs3P_tgGyX8i7SQSUAKNkLwqk2HKa-HjOT8Rz-PpJOLwQAGspVSqUE-RQX5SybLvq6oqYkmwh2NOQ8IebEyr-vGn4bgfhydf9x0DU/s923/)

## Usage
```bash
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe /uninstall /logfile= /LogToConsole=false /c="whoami" clmbypass.exe
```

## Screenshot

![CLM and AppLocker Bypass](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi8VnOjKQ_GNu1yeX2uaJ5hhaGvrwlE_DNHde0J5tyjAV7Uh9Iy1VPYKo5q9_RWz7zEx4fOlrazQCNP4qXIT-TeQXuLTa47u59pl-cIYIzBzxyhyVqVURnnNM86E9dvPqJrRbqsld5D7wNYgyrTEEew-sEdxW3namzXLbeqF7ZnIbQOsIwmuEnru94mSfM/s1219)

## Disclaimer
This tool is intended for educational purposes only. It is designed to assist in learning and improving security skills within a controlled, legal, and ethical environment. The use of this tool in unauthorized systems or networks is strictly prohibited and may violate applicable laws. The author is not responsible for any misuse or illegal activities conducted using this tool. By using this tool, you agree to assume full responsibility for your actions and ensure compliance with all relevant laws and regulations.