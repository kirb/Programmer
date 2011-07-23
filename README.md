    '########::'########:::'#######:::'######:::'########:::::'###::::'##::::'##:'##::::'##:'########:'########::
     ##.... ##: ##.... ##:'##.... ##:'##... ##:: ##.... ##:::'## ##::: ###::'###: ###::'###: ##.....:: ##.... ##:
     ##:::: ##: ##:::: ##: ##:::: ##: ##:::..::: ##:::: ##::'##:. ##:: ####'####: ####'####: ##::::::: ##:::: ##:
     ########:: ########:: ##:::: ##: ##::'####: ########::'##:::. ##: ## ### ##: ## ### ##: ######::: ########::
     ##.....::: ##.. ##::: ##:::: ##: ##::: ##:: ##.. ##::: #########: ##. #: ##: ##. #: ##: ##...:::: ##.. ##:::
     ##:::::::: ##::. ##:: ##:::: ##: ##::: ##:: ##::. ##:: ##.... ##: ##:.:: ##: ##:.:: ##: ##::::::: ##::. ##::
     ##:::::::: ##:::. ##:. #######::. ######::: ##:::. ##: ##:::: ##: ##:::: ##: ##:::: ##: ########: ##:::. ##:
    ..:::::::::..:::::..:::.......::::......::::..:::::..::..:::::..::..:::::..::..:::::..::........::..:::::..::
    
**Version:** 1.0.1.0

Programmer is a Visual Basic program that converts an Assembly (ASM) file to a binary (HEX) file using MPASMWIN, then programs it using the eLabtronics USB Programmer software.

## To make this yourself: ##
1. Download MPASMWIN and place it and the files it requires in a folder called `ASM` in the `programmer\bin\Debug` folder.
2. Find the eLabtronics USB Programmer software and place it in the folder above `ASM`.
3. Open the solution in Visual Studio and click _Debug_ > _Publish programmer_.
4. Find the `giveio.sys` driver for the USB Programmer and place it in the `setup` folder.
5. Run [Inno Setup](http://jrsoftware.org/isdl.php), open the `setup\setup.iss` file and compile it.
6. Test the setup program that was just generated works by installing it on your computer.
7. Rename an `.ASM` file to have the `.usb` file extension and open it. Programmer should open, follow the prompts.

If Programmer doesn't appear after running it in the above step, please check that you did everything properly. If it still doesn't work, please [file an issue](http://github.com/kirbylover4000/Programmer/issues) and I will help you.