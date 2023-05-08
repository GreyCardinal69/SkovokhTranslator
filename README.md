# Skovakh-Translator

![Skovokhl6](https://user-images.githubusercontent.com/50517794/155845894-e96c2d07-6adb-4f33-b911-e899e6153fa0.png)

Skovokh Translator is an application for translating and generating text images for an artificial language called Skovokh.
Skovokh was created by @Estrect. The translator was made by me.

The Skovokh Translator supports:

- Translation of english to latin Skovokh and legit Skovokh.
- Translation of latin Skovokh to english and Skovokh.
- Translation of Skovokh to english and latin Skovokh.
- Supports image generation with 3 modes, such as 10, 20 and 30 letters a line.
- A seperate form for adding new words and translations on the run.

The application's main window looks like this:

![Screenshot 2022-02-26 180205](https://user-images.githubusercontent.com/50517794/155846000-207a6376-51c8-43d5-a3f2-52356376a760.png)

Left Buttons:

First six are for changing translation mode between english-latin-skovokh, simply click on them.
The "Mode" label shows the currently active translation mode, readonly.
"Open Dictionary Editor" button shows a window for adding new translations of the applications dictionaries on the run.
The "20 Chars per layer" button shows how many Skovokh letters will currently be drawn on a single line. To change between 10, 20 and 30 letters a line simply click the button.
"Generate Image" button takes the input from the right corner text input zone and generates a skovokh text image, if the input is valid that is.

Write your input text for translation in the middle top text zone. The translated text will appear in the bottom center text area.

Skovokh consists of the following letters and symbols:

![Skovokhfinal](https://user-images.githubusercontent.com/50517794/155846150-d35ea8ef-9142-4c17-95a0-56d0e9fc7f11.png)

Including the new line character that is added on each new line, if there is one.

![arrow](https://user-images.githubusercontent.com/50517794/155846179-b63d20ae-b9a2-4883-8fb8-5cd2c5d52afe.png)

Generating Images:

- The generated image can be found at img\Step2.
- img\Step0 contains images of Skovokh letters and symbols.
- img\Step1 contains individual generated skovokh text lines.

The translation dictionaries can be found at Lang\

The window for adding new translationns looks like this:

![Screenshot 2022-02-26 181127](https://user-images.githubusercontent.com/50517794/155846287-12a0936f-96c6-4c1f-8e75-038d4e0b0d8c.png)

How to use it:

Write the english word under "Input ( English ) ", then the latin Skovokh version of it under "Input ( Latin Skovokh )".
If the input Latin Skovokh text is invalid a notification will appear, saving the translation to dictionary in that case is impossible. If the Latin Skovokh is translated without issues its legit Skovokh version will appear under "Output ( Skovokh )". To add the translations to the dictionaries simply press "Save". The words are added dynamically, there is no reason to restart the application.

