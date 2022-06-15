# ICE_CodingRound
ICE_CodingRound

## Demo
Demo video - https://youtu.be/HwMrRVDqhDA
This a quick silent demo showing the app created for ICE coding round.

The solution currently consists of 2 main projects -
1. Engine - Webapi running a worker in background acting as an Engine for giving out tickers and updating them every 2 secs.
2. Gui - Winform Application as GUI. This connects and talks with the web api to start and stop the engine, get the ticker data and subscribe to tickers.

Assumptions and magic values - 
Engine - The ticker value refreshes every 2 secs. This can be moved into config.
A Seed data of 3 tickers have been added.
Engine currently has only 1 worker running in the background but this can be easily updated to be multiple workers with each monitoring and updating its own set of tickers.

GUI - For application to show any tickers, one of the engine needs to be started.
Two engines have been hardcoded but can be updated to have multiple engines.
Both Engines are connected to the same backend worker via the api.

