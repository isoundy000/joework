//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HuanJueData
{
    using ProtoBuf;
    using System.Collections.Generic;
    
    
    [ProtoContract()]
    public class HeroInfo
    {
        
        private int m_id;
        
        private string m_name;
        
        private string m_description;
        
        private string m_iconName;
        
        private string m_modelName;
        
        private float m_scale;
        
        private int m_baseSkill;
        
        private int m_qSkill;
        
        private int m_wSkill;
        
        private int m_eSkill;
        
        private int m_rSkill;
        
        /// <summary>
        /// 英雄Id
        /// </summary>
        [ProtoMember(1)]
        public int Id
        {
            get
            {
                return this.m_id;
            }
            set
            {
                this.m_id = value;
            }
        }
        
        /// <summary>
        /// 英雄名称
        /// </summary>
        [ProtoMember(2)]
        public string Name
        {
            get
            {
                return this.m_name;
            }
            set
            {
                this.m_name = value;
            }
        }
        
        /// <summary>
        /// 英雄描述
        /// </summary>
        [ProtoMember(3)]
        public string Description
        {
            get
            {
                return this.m_description;
            }
            set
            {
                this.m_description = value;
            }
        }
        
        /// <summary>
        /// 图标名称
        /// </summary>
        [ProtoMember(4)]
        public string IconName
        {
            get
            {
                return this.m_iconName;
            }
            set
            {
                this.m_iconName = value;
            }
        }
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [ProtoMember(5)]
        public string ModelName
        {
            get
            {
                return this.m_modelName;
            }
            set
            {
                this.m_modelName = value;
            }
        }
        
        /// <summary>
        /// 缩放
        /// </summary>
        [ProtoMember(6)]
        public float Scale
        {
            get
            {
                return this.m_scale;
            }
            set
            {
                this.m_scale = value;
            }
        }
        
        /// <summary>
        /// 被动技能
        /// </summary>
        [ProtoMember(7)]
        public int BaseSkill
        {
            get
            {
                return this.m_baseSkill;
            }
            set
            {
                this.m_baseSkill = value;
            }
        }
        
        /// <summary>
        /// 技能Q
        /// </summary>
        [ProtoMember(8)]
        public int QSkill
        {
            get
            {
                return this.m_qSkill;
            }
            set
            {
                this.m_qSkill = value;
            }
        }
        
        /// <summary>
        /// 技能W
        /// </summary>
        [ProtoMember(9)]
        public int WSkill
        {
            get
            {
                return this.m_wSkill;
            }
            set
            {
                this.m_wSkill = value;
            }
        }
        
        /// <summary>
        /// 技能E
        /// </summary>
        [ProtoMember(10)]
        public int ESkill
        {
            get
            {
                return this.m_eSkill;
            }
            set
            {
                this.m_eSkill = value;
            }
        }
        
        /// <summary>
        /// 技能R
        /// </summary>
        [ProtoMember(11)]
        public int RSkill
        {
            get
            {
                return this.m_rSkill;
            }
            set
            {
                this.m_rSkill = value;
            }
        }
        
        /// <summary>
        /// 主键
        /// </summary>
        public string MainKey
        {
            get
            {
                return this.m_id.ToString();
            }
        }
        
        /// <summary>
        /// 获取SkillInfo
        /// </summary>
        public SkillInfo GetSkillInfo(string inArg0)
        {
            return CfgData.Instance.m_PBData.SkillInfoDic[inArg0];
        }
    }
}
