/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


// targeting netstandard 2.x
#if(! NETSTANDARD2_0_OR_GREATER && ! NET6_0_OR_GREATER && ! NET472_OR_GREATER)
#error Unexpected target platform. See 'thrift --help' for details.
#endif

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable CS0618   // silence our own deprecation warnings
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Apache.Hive.Service.Rpc.Thrift
{

  internal partial class TDBSqlSessionCapabilities : TBase
  {
    private bool _supportsMultipleCatalogs;

    public bool SupportsMultipleCatalogs
    {
      get
      {
        return _supportsMultipleCatalogs;
      }
      set
      {
        __isset.supportsMultipleCatalogs = true;
        this._supportsMultipleCatalogs = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool supportsMultipleCatalogs;
    }

    public TDBSqlSessionCapabilities()
    {
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Bool)
              {
                SupportsMultipleCatalogs = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default:
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp250 = new TStruct("TDBSqlSessionCapabilities");
        await oprot.WriteStructBeginAsync(tmp250, cancellationToken);
        var tmp251 = new TField();
        if(__isset.supportsMultipleCatalogs)
        {
          tmp251.Name = "supportsMultipleCatalogs";
          tmp251.Type = TType.Bool;
          tmp251.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp251, cancellationToken);
          await oprot.WriteBoolAsync(SupportsMultipleCatalogs, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is TDBSqlSessionCapabilities other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.supportsMultipleCatalogs == other.__isset.supportsMultipleCatalogs) && ((!__isset.supportsMultipleCatalogs) || (global::System.Object.Equals(SupportsMultipleCatalogs, other.SupportsMultipleCatalogs))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.supportsMultipleCatalogs)
        {
          hashcode = (hashcode * 397) + SupportsMultipleCatalogs.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp252 = new StringBuilder("TDBSqlSessionCapabilities(");
      int tmp253 = 0;
      if(__isset.supportsMultipleCatalogs)
      {
        if(0 < tmp253++) { tmp252.Append(", "); }
        tmp252.Append("SupportsMultipleCatalogs: ");
        SupportsMultipleCatalogs.ToString(tmp252);
      }
      tmp252.Append(')');
      return tmp252.ToString();
    }
  }

}
