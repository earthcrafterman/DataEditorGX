/*
 * 由SharpDevelop创建。
 * 用户： Acer
 * 日期: 2014-10-13
 * 时间: 9:44
 * 
 */
using System;

namespace DataEditorX.Core.Info
{
    /// <summary>
    /// 卡片种族
    /// </summary>
    public enum CardRace : long
    {
        RACE_NONE = 0,
        ///<summary>战士</summary>
        RACE_WARRIOR = 0x1,
        ///<summary>魔法师</summary>
        RACE_SPELLCASTER = 0x2,
        ///<summary>天使</summary>
        RACE_FAIRY = 0x4,
        ///<summary>恶魔</summary>
        RACE_FIEND = 0x8,
        ///<summary>不死</summary>
        RACE_ZOMBIE = 0x10,
        ///<summary>机械</summary>
        RACE_MACHINE = 0x20,
        ///<summary>水生</summary>
        RACE_AQUATIC = 0x40,
        ///<summary>素子</summary>
        RACE_ELEMENTAL = 0x80,
        ///<summary>植物</summary>
        RACE_PLANT = 0x400,
        ///<summary>昆虫</summary>
        RACE_INSECT = 0x800,
        ///<summary>龙</summary>
        RACE_DRAGON = 0x2000,
        ///<summary>兽</summary>
        RACE_BEAST = 0x4000,
        ///<summary>爬虫</summary>
        RACE_REPTILE = 0x80000,
        ///<summary>念动力</summary>
        RACE_PSYCHO = 0x100000,
        ///<summary>幻神兽</summary>
        RACE_DEVINE = 0x200000,
    }
}
