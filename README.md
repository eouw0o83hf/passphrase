# Passphrase

A dependency-free, high-entropy, high-typability  english word password generator.

In the form of [xkcd](https://xkcd.com/936/), generates a high-entropy password that's possible to remember and type. Useful for high-connectivity accounts (iCloud, Google, Facebook) which you may have to sign into on a mobile device where typing special characters is difficult.

## How to run

1. [Install dotnet core](https://dotnet.microsoft.com/download)
2. Type `dotnet run` at the command line to receive a randomized password

## Output

A random seven-word password, for example

    balanced hints cutting acoustic announce apnic horizontal

## Why use this instead of a web app?

I don't trust javascript in a web browser to generate a password for me - there are any number of ways that the process could be compromised.

The code in this generator is extremely minimal, and it's easy to see that nothing subversive is occurring.

