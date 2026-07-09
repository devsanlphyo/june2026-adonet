### June2026.SQLInjection
In this program, I tested how SQL Injections are occured and how to protected them. I create a simple program which will help to test the injection. I also provided how I tested and test results.

#### Test Result
```
[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: San Linn Phyo
Enter password: ' --
Login failed!

[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: San Linn Phyo' --
Enter password:
Login success
User: {DapperRow, Id = '1', Username = 'San Linn Phyo', Password = '123', Bio = 'Software Developer'}

[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: Admin
Enter password: admin
Login success
User: {DapperRow, Id = '3', Username = 'Admin', Password = 'admin', Bio = 'Admin Account'}

[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: Admin' --
Enter password:
Login success
User: {DapperRow, Id = '3', Username = 'Admin', Password = 'admin', Bio = 'Admin Account'}

[1] Vulnerable, [2] Secured, [0] Exist: 2
Enter username: San Linn Phyo
Enter password: 123
Login successful
User: {DapperRow, Id = '1', Username = 'San Linn Phyo', Password = '123', Bio = 'Software Developer'}

[1] Vulnerable, [2] Secured, [0] Exist: 2
Enter username: Admin
Enter password: ' OR 1 = 1 + '
Login failed!


[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: Admin
Enter password: ' OR 1 = 1 + '
Login success
User: {DapperRow, Id = '1', Username = 'San Linn Phyo', Password = '123', Bio = 'Software Developer'}

[1] Vulnerable, [2] Secured, [0] Exist: 2
Enter username: Admin' --
Enter password:
Login failed!


[1] Vulnerable, [2] Secured, [0] Exist: 2
Enter username: Admin' --
Enter password:
Login failed!


[1] Vulnerable, [2] Secured, [0] Exist: 1
Enter username: Admin' --
Enter password:
Login success
User: {DapperRow, Id = '3', Username = 'Admin', Password = 'admin', Bio = 'Admin Account'}

[1] Vulnerable, [2] Secured, [0] Exist: 0

C:\Users\sanlphyo\workspace\csharpworkspace\June2026\June2026.SQLInjection\bin\Debug\net8.0\June2026.SQLInjection.exe (process 21404) exited with code 0 (0x0).
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
```