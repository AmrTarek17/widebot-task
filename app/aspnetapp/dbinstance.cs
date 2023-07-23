using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using aspnetapp;
using Microsoft.Extensions.Hosting;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;

class DBinstance
{
    public static IDatabase CreateDBinstance(string[] args) {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(Environment.GetEnvironmentVariable("Databases"));
        IDatabase db = redis.GetDatabase();
        return db;
    }

}