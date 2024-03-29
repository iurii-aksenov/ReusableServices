﻿using System;

namespace ReusableServices.Common.CommandLine
{
  public class HelpCommand : ICommand
  {
    public string CommandName { get; set; }

    public bool Verbose { get; set; }

    public int PageSize { get; set; }

    public void Run()
    {
      if (CommandName == "host")
      {
        Console.WriteLine("-p|-port is for defining the port");
        Console.WriteLine("-sw|-swagger is for creating json swagger info");
        Console.WriteLine("-curdir|-currentdirectorz is for setting the base directorz");
      }
    }
  }
}