﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// GNSS 模块详细定位数据采集频率，单位为秒，默认为 1。
    /// </summary>
    public class JT808_0x8103_0x0093 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0x0093>
    {
        public override uint ParamId { get; set; } = 0x0093;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; }
        /// <summary>
        /// GNSS 模块详细定位数据采集频率，单位为秒，默认为 1。
        /// </summary>
        public uint ParamValue { get; set; }
        public JT808_0x8103_0x0093 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0x0093 jT808_0x8103_0x0093 = new JT808_0x8103_0x0093();
            jT808_0x8103_0x0093.ParamId = reader.ReadUInt32();
            jT808_0x8103_0x0093.ParamLength = reader.ReadByte();
            jT808_0x8103_0x0093.ParamValue = reader.ReadUInt32();
            return jT808_0x8103_0x0093;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0x0093 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.WriteByte(value.ParamLength);
            writer.WriteUInt32(value.ParamValue);
        }
    }
}
