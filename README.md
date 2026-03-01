# IdleOn Wiki Ingestor

A C# .NET 10 Console Application designed to act as an ETL (Extract, Transform, Load) pipeline for the official IdleOn Wiki.

This ingestion engine fetches raw game data via the MediaWiki Action API, cleans and structures the unstructured HTML/JSON, and prepares it for local database storage and Markdown generation.

