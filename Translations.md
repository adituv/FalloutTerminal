# Translating this Application

To contribute a translation to this application, you have one of two options.
First, you can submit an Issue on GitHub containing the required translations;
or second, you can do it yourself and submit a pull request.  The latter
requires a (relatively recent) version of Visual Studio.

## 1. GitHub Issue

If you choose to submit an issue, I need the following translated from English:

* OK
* Cancel
* Reset
* (Edit...)
* Matches
* Word
* Terminal Hacking
* Edit Available Words

The translations may be loose - in fact, this is preferable if it feels more
natural to a native speaker.  For example, 'Edit Available Words' was rendered
in Japanese as 言・エディター (Word Editor).

## 2. Pull Request

Creating a new translation in Visual Studio is relatively easy if you can
design basic Windows Forms already.  In the designer, select the form, then
change the 'Language' property to your target language.  Now edit the text on
the form to contain your translation, and rearrange the user interface slightly
to make it more attractive:

![Screenshot in English](http://i.imgur.com/N6618Ug.png)
![Screenshot in Japanese](http://i.imgur.com/9LsUj8t.png)

[Direct comparison](http://imgur.com/a/X5zqX)

As you can see, the word selection box is larger in the Japanese version as the
static labels take up less space.

**Major caveat:** this application contains a hidden label underneath the list
of remaining candidate passwords.  Make sure you translate `lblEditText`, which
is accessible from the drop down list at the top of the Properties window.