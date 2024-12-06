# Localization

<video width="320" height="240" controls>
  <source src="/wiki/demo-localization.mp4" type="video/mp4">
</video>

1. Create a folder `localization`
2. Create a file named `localization.csv` in the above folder with the following structure...

| Text Id               | en              | es              | other_language_iso_codes |
|-----------------------|-----------------|-----------------|--------------------------|
| BALANCE               | Balance         | Saldo           | the relevant translation |
| SPIN                  | Spin            | Giro            | the relevant translation |
| SOME_UNIQUE_REFERENCE | English version | Spanish version | the relevant translation |


3. Open your project in Godot Editor
4. You will notice that Godot will automatically create `localization.language_iso_code.translation` files for each language in your csv
5. Open Project settings > Localization > Translations
6. Add in the generated translation files that you want to support

---

### Others
Could not find a game that let you change the language whilst in the game

However, Pragmatic play let you change the language before you load the game

https://www.pragmaticplay.com/en/games/gates-of-olympus-xmas-1000/?gamelang=bg&cur=USD

---

## TODO

Listen to the event [`NOTIFICATION_TRANSLATION_CHANGED`](https://docs.godotengine.org/en/3.4/classes/class_node.html#class-node-constant-notification-translation-changed)

---

#### References

https://www.youtube.com/watch?v=v0tJPsNNOM8

https://github.com/cashew-olddew/godot-tutorials/tree/c69b70e3f637cf415397f55ba2195ca84ef232c0/4.2/5%20-%20localization


### Changing localization:
* Edit the `localization/localization.csv`
* Save the file
* Wait for Godot to reload the project assets
* Done


