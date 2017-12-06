
















// Generated on 10/13/2017 02:18:54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SpellItemBoostMessage : Message
{

public const uint Id = 6011;
public override uint MessageId
{
    get { return Id; }
}

public int statId;
        public short spellId;
        public short value;
        

public SpellItemBoostMessage()
{
}

public SpellItemBoostMessage(int statId, short spellId, short value)
        {
            this.statId = statId;
            this.spellId = spellId;
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(statId);
            writer.WriteShort(spellId);
            writer.WriteShort(value);
            

}

public override void Deserialize(IDataReader reader)
{

statId = reader.ReadInt();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = reader.ReadShort();
            

}


}


}
