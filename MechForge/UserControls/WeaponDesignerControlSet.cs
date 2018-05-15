using System.Windows.Forms;
using MechForge.Domain;
using Newtonsoft.Json;

namespace MechForge.UserControls
{


    public class WeaponDesignerControlSet : UserControl, IDesignable
    {
        private Weapon weapon;
        private TransparentGroupBox groupBox1;
        private TextField WeaponSubType;
        private TextField Type;
        private TextField Category;
        private TransparentGroupBox groupBox2;
        private TextField RangeSplit;
        private TextField MaxRange;
        private TextField MinRange;
        private TransparentGroupBox groupBox3;
        private TextField RefireModifier;
        private TextField IndirectFireCapable;
        private TextField AOECapable;
        private TextField CriticalChanceMultiplier;
        private TextField AccuracyModifier;
        private TextField HeatDamage;
        private TextField DamageVariance;
        private TextField EvasivePipsIgnored;
        private TextField EvasiveDamageMultiplier;
        private TextField OverheatedDamageMultiplier;
        private TextField Damage;
        private TextField HeatGenerated;
        private TextField StartingAmmoCapacity;
        private TextField AmmoCategory;
        private TransparentGroupBox groupBox4;
        private TextField WeaponEffectID;
        private TextField Instability;
        private TextField AttackRecoil;
        private TextField ProjectilesPerShot;
        private TextField ShotsWhenFired;
        private TransparentGroupBox groupBox5;
        private TextField ComponentSubType;
        private TextField ComponentType;
        private TextField CriticalComponent;
        private TextField DisallowedLocations;
        private TextField AllowedLocations;
        private TextField Tonnage;
        private TextField InventorySize;
        private TransparentGroupBox groupBox6;
        private TextField statusEffects;
        private TransparentGroupBox groupBox7;
        private TextField BonusValueB;
        private TextField BonusValueA;
        private TransparentGroupBox groupBox8;
        private TextField BattleValue;
        private TextField PrefabIdentifier;

        public string JsonData
        { 
            set
            {
                try
                {
                    weapon = JsonConvert.DeserializeObject<Weapon>(value);
                    this.Category.TextBox.Text = weapon.Category;

                    this.Type.TextBox.Text = weapon.Category;
                    this.WeaponSubType.TextBox.Text = weapon.WeaponSubType;
                    this.MinRange.TextBox.Text = weapon.MinRange.ToString();
                    this.MaxRange.TextBox.Text = weapon.MaxRange.ToString();
                    this.CriticalChanceMultiplier.TextBox.Text = weapon.CriticalChanceMultiplier.ToString();
                    this.AccuracyModifier.TextBox.Text = weapon.AccuracyModifier.ToString();
                    this.HeatDamage.TextBox.Text = weapon.HeatDamage.ToString();
                    this.DamageVariance.TextBox.Text = weapon.DamageVariance.ToString();
                    this.EvasivePipsIgnored.TextBox.Text = weapon.EvasivePipsIgnored.ToString();
                    this.EvasiveDamageMultiplier.TextBox.Text = weapon.EvasiveDamageMultiplier.ToString();
                    this.OverheatedDamageMultiplier.TextBox.Text = weapon.OverheatedDamageMultiplier.ToString();
                    this.Damage.TextBox.Text = weapon.Damage.ToString();
                    this.HeatGenerated.TextBox.Text = weapon.HeatGenerated.ToString();
                    this.StartingAmmoCapacity.TextBox.Text = weapon.StartingAmmoCapacity.ToString();
                    this.AmmoCategory.TextBox.Text = weapon.AmmoCategory.ToString();
                    this.RangeSplit.TextBox.Text = weapon.RangeSplit.ToString();
                    this.CriticalComponent.TextBox.Text = weapon.CriticalComponent.ToString(); ;
                    this.DisallowedLocations.TextBox.Text = weapon.DisallowedLocations;
                    this.AllowedLocations.TextBox.Text = weapon.AllowedLocations;
                    this.Tonnage.TextBox.Text = weapon.Tonnage.ToString(); ;
                    this.InventorySize.TextBox.Text = weapon.InventorySize.ToString(); ;
                    this.BattleValue.TextBox.Text = weapon.BattleValue.ToString(); ;
                    this.PrefabIdentifier.TextBox.Text = weapon.PrefabIdentifier;
                    this.ComponentSubType.TextBox.Text = weapon.ComponentSubType;
                    this.ComponentType.TextBox.Text = weapon.ComponentType;
                    this.BonusValueB.TextBox.Text = weapon.BonusValueB;
                    this.BonusValueA.TextBox.Text = weapon.BonusValueA;
                    this.WeaponEffectID.TextBox.Text = weapon.WeaponEffectId.ToString(); ;
                    this.Instability.TextBox.Text = weapon.Instability.ToString();
                    this.AttackRecoil.TextBox.Text = weapon.AttackRecoil.ToString();
                    this.ProjectilesPerShot.TextBox.Text = weapon.ProjectilesPerShot.ToString();
                    this.ShotsWhenFired.TextBox.Text = weapon.ShotsWhenFired.ToString();
                    this.RefireModifier.TextBox.Text = weapon.RefireModifier.ToString();
                    this.IndirectFireCapable.TextBox.Text = weapon.IndirectFireCapable.ToString();
                    this.AOECapable.TextBox.Text = weapon.AoeCapable.ToString();


                    this.statusEffects.TextBox.Text = weapon.Category;
                }
                catch (JsonException ex)
                {
                    //swallow for now
                }
                

    }
        }
        private Label label1;

        public WeaponDesignerControlSet()
        {
            
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new MechForge.UserControls.TransparentGroupBox();
            this.WeaponSubType = new MechForge.UserControls.TextField();
            this.Type = new MechForge.UserControls.TextField();
            this.Category = new MechForge.UserControls.TextField();
            this.groupBox2 = new MechForge.UserControls.TransparentGroupBox();
            this.RangeSplit = new MechForge.UserControls.TextField();
            this.MaxRange = new MechForge.UserControls.TextField();
            this.MinRange = new MechForge.UserControls.TextField();
            this.groupBox3 = new MechForge.UserControls.TransparentGroupBox();
            this.RefireModifier = new MechForge.UserControls.TextField();
            this.IndirectFireCapable = new MechForge.UserControls.TextField();
            this.AOECapable = new MechForge.UserControls.TextField();
            this.CriticalChanceMultiplier = new MechForge.UserControls.TextField();
            this.AccuracyModifier = new MechForge.UserControls.TextField();
            this.HeatDamage = new MechForge.UserControls.TextField();
            this.DamageVariance = new MechForge.UserControls.TextField();
            this.EvasivePipsIgnored = new MechForge.UserControls.TextField();
            this.EvasiveDamageMultiplier = new MechForge.UserControls.TextField();
            this.OverheatedDamageMultiplier = new MechForge.UserControls.TextField();
            this.Damage = new MechForge.UserControls.TextField();
            this.HeatGenerated = new MechForge.UserControls.TextField();
            this.StartingAmmoCapacity = new MechForge.UserControls.TextField();
            this.AmmoCategory = new MechForge.UserControls.TextField();
            this.groupBox4 = new MechForge.UserControls.TransparentGroupBox();
            this.WeaponEffectID = new MechForge.UserControls.TextField();
            this.Instability = new MechForge.UserControls.TextField();
            this.AttackRecoil = new MechForge.UserControls.TextField();
            this.ProjectilesPerShot = new MechForge.UserControls.TextField();
            this.ShotsWhenFired = new MechForge.UserControls.TextField();
            this.groupBox5 = new MechForge.UserControls.TransparentGroupBox();
            this.ComponentSubType = new MechForge.UserControls.TextField();
            this.ComponentType = new MechForge.UserControls.TextField();
            this.CriticalComponent = new MechForge.UserControls.TextField();
            this.DisallowedLocations = new MechForge.UserControls.TextField();
            this.AllowedLocations = new MechForge.UserControls.TextField();
            this.Tonnage = new MechForge.UserControls.TextField();
            this.InventorySize = new MechForge.UserControls.TextField();
            this.groupBox6 = new MechForge.UserControls.TransparentGroupBox();
            this.statusEffects = new MechForge.UserControls.TextField();
            this.groupBox7 = new MechForge.UserControls.TransparentGroupBox();
            this.BonusValueB = new MechForge.UserControls.TextField();
            this.BonusValueA = new MechForge.UserControls.TextField();
            this.groupBox8 = new MechForge.UserControls.TransparentGroupBox();
            this.BattleValue = new MechForge.UserControls.TextField();
            this.PrefabIdentifier = new MechForge.UserControls.TextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 25);
            this.label1.MinimumSize = new System.Drawing.Size(400, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon Designer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeaponSubType);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // WeaponSubType
            // 
            this.WeaponSubType.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeaponSubType.LabelText = "WeaponSubType";
            this.WeaponSubType.Location = new System.Drawing.Point(3, 66);
            this.WeaponSubType.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.WeaponSubType.MaximumSize = new System.Drawing.Size(0, 25);
            this.WeaponSubType.MinimumSize = new System.Drawing.Size(400, 25);
            this.WeaponSubType.Name = "WeaponSubType";
            this.WeaponSubType.Size = new System.Drawing.Size(1134, 25);
            this.WeaponSubType.TabIndex = 10;
            this.WeaponSubType.TextFieldText = "";
            // 
            // Type
            // 
            this.Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.Type.LabelText = "Type";
            this.Type.Location = new System.Drawing.Point(3, 41);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Type.MaximumSize = new System.Drawing.Size(0, 25);
            this.Type.MinimumSize = new System.Drawing.Size(400, 25);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(1134, 25);
            this.Type.TabIndex = 9;
            this.Type.TextFieldText = "";
            // 
            // Category
            // 
            this.Category.Dock = System.Windows.Forms.DockStyle.Top;
            this.Category.LabelText = "Category";
            this.Category.Location = new System.Drawing.Point(3, 16);
            this.Category.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Category.MaximumSize = new System.Drawing.Size(0, 25);
            this.Category.MinimumSize = new System.Drawing.Size(400, 25);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(1134, 25);
            this.Category.TabIndex = 8;
            this.Category.TextFieldText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RangeSplit);
            this.groupBox2.Controls.Add(this.MaxRange);
            this.groupBox2.Controls.Add(this.MinRange);
            this.groupBox2.Location = new System.Drawing.Point(421, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Range Settings";
            // 
            // RangeSplit
            // 
            this.RangeSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.RangeSplit.LabelText = "RangeSplit";
            this.RangeSplit.Location = new System.Drawing.Point(3, 66);
            this.RangeSplit.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.RangeSplit.MaximumSize = new System.Drawing.Size(0, 25);
            this.RangeSplit.MinimumSize = new System.Drawing.Size(300, 25);
            this.RangeSplit.Name = "RangeSplit";
            this.RangeSplit.Size = new System.Drawing.Size(369, 25);
            this.RangeSplit.TabIndex = 7;
            this.RangeSplit.TextFieldText = "";
            // 
            // MaxRange
            // 
            this.MaxRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxRange.LabelText = "MaxRange";
            this.MaxRange.Location = new System.Drawing.Point(3, 41);
            this.MaxRange.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.MaxRange.MaximumSize = new System.Drawing.Size(0, 25);
            this.MaxRange.MinimumSize = new System.Drawing.Size(300, 25);
            this.MaxRange.Name = "MaxRange";
            this.MaxRange.Size = new System.Drawing.Size(369, 25);
            this.MaxRange.TabIndex = 6;
            this.MaxRange.TextFieldText = "";
            // 
            // MinRange
            // 
            this.MinRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinRange.LabelText = "MinRange";
            this.MinRange.Location = new System.Drawing.Point(3, 16);
            this.MinRange.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.MinRange.MaximumSize = new System.Drawing.Size(0, 25);
            this.MinRange.MinimumSize = new System.Drawing.Size(300, 25);
            this.MinRange.Name = "MinRange";
            this.MinRange.Size = new System.Drawing.Size(369, 25);
            this.MinRange.TabIndex = 5;
            this.MinRange.TextFieldText = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefireModifier);
            this.groupBox3.Controls.Add(this.IndirectFireCapable);
            this.groupBox3.Controls.Add(this.AOECapable);
            this.groupBox3.Controls.Add(this.CriticalChanceMultiplier);
            this.groupBox3.Controls.Add(this.AccuracyModifier);
            this.groupBox3.Controls.Add(this.HeatDamage);
            this.groupBox3.Controls.Add(this.DamageVariance);
            this.groupBox3.Controls.Add(this.EvasivePipsIgnored);
            this.groupBox3.Controls.Add(this.EvasiveDamageMultiplier);
            this.groupBox3.Controls.Add(this.OverheatedDamageMultiplier);
            this.groupBox3.Controls.Add(this.Damage);
            this.groupBox3.Controls.Add(this.HeatGenerated);
            this.groupBox3.Controls.Add(this.StartingAmmoCapacity);
            this.groupBox3.Controls.Add(this.AmmoCategory);
            this.groupBox3.Location = new System.Drawing.Point(21, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 412);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weapon Stats";
            // 
            // RefireModifier
            // 
            this.RefireModifier.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefireModifier.LabelText = "RefireModifier";
            this.RefireModifier.Location = new System.Drawing.Point(3, 341);
            this.RefireModifier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.RefireModifier.MaximumSize = new System.Drawing.Size(0, 25);
            this.RefireModifier.MinimumSize = new System.Drawing.Size(300, 25);
            this.RefireModifier.Name = "RefireModifier";
            this.RefireModifier.Size = new System.Drawing.Size(385, 25);
            this.RefireModifier.TabIndex = 21;
            this.RefireModifier.TextFieldText = "";
            // 
            // IndirectFireCapable
            // 
            this.IndirectFireCapable.Dock = System.Windows.Forms.DockStyle.Top;
            this.IndirectFireCapable.LabelText = "IndirectFireCapable";
            this.IndirectFireCapable.Location = new System.Drawing.Point(3, 316);
            this.IndirectFireCapable.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.IndirectFireCapable.MaximumSize = new System.Drawing.Size(0, 25);
            this.IndirectFireCapable.MinimumSize = new System.Drawing.Size(300, 25);
            this.IndirectFireCapable.Name = "IndirectFireCapable";
            this.IndirectFireCapable.Size = new System.Drawing.Size(385, 25);
            this.IndirectFireCapable.TabIndex = 20;
            this.IndirectFireCapable.TextFieldText = "";
            // 
            // AOECapable
            // 
            this.AOECapable.Dock = System.Windows.Forms.DockStyle.Top;
            this.AOECapable.LabelText = "AOECapable";
            this.AOECapable.Location = new System.Drawing.Point(3, 291);
            this.AOECapable.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AOECapable.MaximumSize = new System.Drawing.Size(0, 25);
            this.AOECapable.MinimumSize = new System.Drawing.Size(300, 25);
            this.AOECapable.Name = "AOECapable";
            this.AOECapable.Size = new System.Drawing.Size(385, 25);
            this.AOECapable.TabIndex = 19;
            this.AOECapable.TextFieldText = "";
            // 
            // CriticalChanceMultiplier
            // 
            this.CriticalChanceMultiplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.CriticalChanceMultiplier.LabelText = "CriticalChanceMultiplier";
            this.CriticalChanceMultiplier.Location = new System.Drawing.Point(3, 266);
            this.CriticalChanceMultiplier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CriticalChanceMultiplier.MaximumSize = new System.Drawing.Size(0, 25);
            this.CriticalChanceMultiplier.MinimumSize = new System.Drawing.Size(300, 25);
            this.CriticalChanceMultiplier.Name = "CriticalChanceMultiplier";
            this.CriticalChanceMultiplier.Size = new System.Drawing.Size(385, 25);
            this.CriticalChanceMultiplier.TabIndex = 18;
            this.CriticalChanceMultiplier.TextFieldText = "";
            // 
            // AccuracyModifier
            // 
            this.AccuracyModifier.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccuracyModifier.LabelText = "AccuracyModifier";
            this.AccuracyModifier.Location = new System.Drawing.Point(3, 241);
            this.AccuracyModifier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AccuracyModifier.MaximumSize = new System.Drawing.Size(0, 25);
            this.AccuracyModifier.MinimumSize = new System.Drawing.Size(300, 25);
            this.AccuracyModifier.Name = "AccuracyModifier";
            this.AccuracyModifier.Size = new System.Drawing.Size(385, 25);
            this.AccuracyModifier.TabIndex = 17;
            this.AccuracyModifier.TextFieldText = "";
            // 
            // HeatDamage
            // 
            this.HeatDamage.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeatDamage.LabelText = "HeatDamage";
            this.HeatDamage.Location = new System.Drawing.Point(3, 216);
            this.HeatDamage.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.HeatDamage.MaximumSize = new System.Drawing.Size(0, 25);
            this.HeatDamage.MinimumSize = new System.Drawing.Size(300, 25);
            this.HeatDamage.Name = "HeatDamage";
            this.HeatDamage.Size = new System.Drawing.Size(385, 25);
            this.HeatDamage.TabIndex = 16;
            this.HeatDamage.TextFieldText = "";
            // 
            // DamageVariance
            // 
            this.DamageVariance.Dock = System.Windows.Forms.DockStyle.Top;
            this.DamageVariance.LabelText = "DamageVariance";
            this.DamageVariance.Location = new System.Drawing.Point(3, 191);
            this.DamageVariance.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DamageVariance.MaximumSize = new System.Drawing.Size(0, 25);
            this.DamageVariance.MinimumSize = new System.Drawing.Size(300, 25);
            this.DamageVariance.Name = "DamageVariance";
            this.DamageVariance.Size = new System.Drawing.Size(385, 25);
            this.DamageVariance.TabIndex = 15;
            this.DamageVariance.TextFieldText = "";
            // 
            // EvasivePipsIgnored
            // 
            this.EvasivePipsIgnored.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvasivePipsIgnored.LabelText = "EvasivePipsIgnored";
            this.EvasivePipsIgnored.Location = new System.Drawing.Point(3, 166);
            this.EvasivePipsIgnored.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.EvasivePipsIgnored.MaximumSize = new System.Drawing.Size(0, 25);
            this.EvasivePipsIgnored.MinimumSize = new System.Drawing.Size(300, 25);
            this.EvasivePipsIgnored.Name = "EvasivePipsIgnored";
            this.EvasivePipsIgnored.Size = new System.Drawing.Size(385, 25);
            this.EvasivePipsIgnored.TabIndex = 14;
            this.EvasivePipsIgnored.TextFieldText = "";
            // 
            // EvasiveDamageMultiplier
            // 
            this.EvasiveDamageMultiplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvasiveDamageMultiplier.LabelText = "EvasiveDamageMultiplier";
            this.EvasiveDamageMultiplier.Location = new System.Drawing.Point(3, 141);
            this.EvasiveDamageMultiplier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.EvasiveDamageMultiplier.MaximumSize = new System.Drawing.Size(0, 25);
            this.EvasiveDamageMultiplier.MinimumSize = new System.Drawing.Size(300, 25);
            this.EvasiveDamageMultiplier.Name = "EvasiveDamageMultiplier";
            this.EvasiveDamageMultiplier.Size = new System.Drawing.Size(385, 25);
            this.EvasiveDamageMultiplier.TabIndex = 13;
            this.EvasiveDamageMultiplier.TextFieldText = "";
            // 
            // OverheatedDamageMultiplier
            // 
            this.OverheatedDamageMultiplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.OverheatedDamageMultiplier.LabelText = "OverheatedDamageMultiplier";
            this.OverheatedDamageMultiplier.Location = new System.Drawing.Point(3, 116);
            this.OverheatedDamageMultiplier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.OverheatedDamageMultiplier.MaximumSize = new System.Drawing.Size(0, 25);
            this.OverheatedDamageMultiplier.MinimumSize = new System.Drawing.Size(300, 25);
            this.OverheatedDamageMultiplier.Name = "OverheatedDamageMultiplier";
            this.OverheatedDamageMultiplier.Size = new System.Drawing.Size(385, 25);
            this.OverheatedDamageMultiplier.TabIndex = 12;
            this.OverheatedDamageMultiplier.TextFieldText = "";
            // 
            // Damage
            // 
            this.Damage.Dock = System.Windows.Forms.DockStyle.Top;
            this.Damage.LabelText = "Damage";
            this.Damage.Location = new System.Drawing.Point(3, 91);
            this.Damage.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Damage.MaximumSize = new System.Drawing.Size(0, 25);
            this.Damage.MinimumSize = new System.Drawing.Size(300, 25);
            this.Damage.Name = "Damage";
            this.Damage.Size = new System.Drawing.Size(385, 25);
            this.Damage.TabIndex = 11;
            this.Damage.TextFieldText = "";
            // 
            // HeatGenerated
            // 
            this.HeatGenerated.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeatGenerated.LabelText = "HeatGenerated";
            this.HeatGenerated.Location = new System.Drawing.Point(3, 66);
            this.HeatGenerated.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.HeatGenerated.MaximumSize = new System.Drawing.Size(0, 25);
            this.HeatGenerated.MinimumSize = new System.Drawing.Size(300, 25);
            this.HeatGenerated.Name = "HeatGenerated";
            this.HeatGenerated.Size = new System.Drawing.Size(385, 25);
            this.HeatGenerated.TabIndex = 10;
            this.HeatGenerated.TextFieldText = "";
            // 
            // StartingAmmoCapacity
            // 
            this.StartingAmmoCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartingAmmoCapacity.LabelText = "StartingAmmoCapacity";
            this.StartingAmmoCapacity.Location = new System.Drawing.Point(3, 41);
            this.StartingAmmoCapacity.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.StartingAmmoCapacity.MaximumSize = new System.Drawing.Size(0, 25);
            this.StartingAmmoCapacity.MinimumSize = new System.Drawing.Size(300, 25);
            this.StartingAmmoCapacity.Name = "StartingAmmoCapacity";
            this.StartingAmmoCapacity.Size = new System.Drawing.Size(385, 25);
            this.StartingAmmoCapacity.TabIndex = 9;
            this.StartingAmmoCapacity.TextFieldText = "";
            // 
            // AmmoCategory
            // 
            this.AmmoCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmmoCategory.LabelText = "AmmoCategory";
            this.AmmoCategory.Location = new System.Drawing.Point(3, 16);
            this.AmmoCategory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AmmoCategory.MaximumSize = new System.Drawing.Size(0, 25);
            this.AmmoCategory.MinimumSize = new System.Drawing.Size(300, 25);
            this.AmmoCategory.Name = "AmmoCategory";
            this.AmmoCategory.Size = new System.Drawing.Size(385, 25);
            this.AmmoCategory.TabIndex = 8;
            this.AmmoCategory.TextFieldText = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WeaponEffectID);
            this.groupBox4.Controls.Add(this.Instability);
            this.groupBox4.Controls.Add(this.AttackRecoil);
            this.groupBox4.Controls.Add(this.ProjectilesPerShot);
            this.groupBox4.Controls.Add(this.ShotsWhenFired);
            this.groupBox4.Location = new System.Drawing.Point(418, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 151);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Firing Characteristics";
            // 
            // WeaponEffectID
            // 
            this.WeaponEffectID.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeaponEffectID.LabelText = "WeaponEffectID";
            this.WeaponEffectID.Location = new System.Drawing.Point(3, 116);
            this.WeaponEffectID.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.WeaponEffectID.MaximumSize = new System.Drawing.Size(0, 25);
            this.WeaponEffectID.MinimumSize = new System.Drawing.Size(300, 25);
            this.WeaponEffectID.Name = "WeaponEffectID";
            this.WeaponEffectID.Size = new System.Drawing.Size(372, 25);
            this.WeaponEffectID.TabIndex = 26;
            this.WeaponEffectID.TextFieldText = "";
            // 
            // Instability
            // 
            this.Instability.Dock = System.Windows.Forms.DockStyle.Top;
            this.Instability.LabelText = "Instability";
            this.Instability.Location = new System.Drawing.Point(3, 91);
            this.Instability.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Instability.MaximumSize = new System.Drawing.Size(0, 25);
            this.Instability.MinimumSize = new System.Drawing.Size(300, 25);
            this.Instability.Name = "Instability";
            this.Instability.Size = new System.Drawing.Size(372, 25);
            this.Instability.TabIndex = 25;
            this.Instability.TextFieldText = "";
            // 
            // AttackRecoil
            // 
            this.AttackRecoil.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttackRecoil.LabelText = "AttackRecoil";
            this.AttackRecoil.Location = new System.Drawing.Point(3, 66);
            this.AttackRecoil.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AttackRecoil.MaximumSize = new System.Drawing.Size(0, 25);
            this.AttackRecoil.MinimumSize = new System.Drawing.Size(300, 25);
            this.AttackRecoil.Name = "AttackRecoil";
            this.AttackRecoil.Size = new System.Drawing.Size(372, 25);
            this.AttackRecoil.TabIndex = 24;
            this.AttackRecoil.TextFieldText = "";
            // 
            // ProjectilesPerShot
            // 
            this.ProjectilesPerShot.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectilesPerShot.LabelText = "ProjectilesPerShot";
            this.ProjectilesPerShot.Location = new System.Drawing.Point(3, 41);
            this.ProjectilesPerShot.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ProjectilesPerShot.MaximumSize = new System.Drawing.Size(0, 25);
            this.ProjectilesPerShot.MinimumSize = new System.Drawing.Size(300, 25);
            this.ProjectilesPerShot.Name = "ProjectilesPerShot";
            this.ProjectilesPerShot.Size = new System.Drawing.Size(372, 25);
            this.ProjectilesPerShot.TabIndex = 23;
            this.ProjectilesPerShot.TextFieldText = "";
            // 
            // ShotsWhenFired
            // 
            this.ShotsWhenFired.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShotsWhenFired.LabelText = "ShotsWhenFired";
            this.ShotsWhenFired.Location = new System.Drawing.Point(3, 16);
            this.ShotsWhenFired.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ShotsWhenFired.MaximumSize = new System.Drawing.Size(0, 25);
            this.ShotsWhenFired.MinimumSize = new System.Drawing.Size(300, 25);
            this.ShotsWhenFired.Name = "ShotsWhenFired";
            this.ShotsWhenFired.Size = new System.Drawing.Size(372, 25);
            this.ShotsWhenFired.TabIndex = 22;
            this.ShotsWhenFired.TextFieldText = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ComponentSubType);
            this.groupBox5.Controls.Add(this.ComponentType);
            this.groupBox5.Controls.Add(this.CriticalComponent);
            this.groupBox5.Controls.Add(this.DisallowedLocations);
            this.groupBox5.Controls.Add(this.AllowedLocations);
            this.groupBox5.Controls.Add(this.Tonnage);
            this.groupBox5.Controls.Add(this.InventorySize);
            this.groupBox5.Location = new System.Drawing.Point(424, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 203);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fitting";
            // 
            // ComponentSubType
            // 
            this.ComponentSubType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComponentSubType.LabelText = "ComponentSubType";
            this.ComponentSubType.Location = new System.Drawing.Point(3, 166);
            this.ComponentSubType.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ComponentSubType.MaximumSize = new System.Drawing.Size(0, 25);
            this.ComponentSubType.MinimumSize = new System.Drawing.Size(300, 25);
            this.ComponentSubType.Name = "ComponentSubType";
            this.ComponentSubType.Size = new System.Drawing.Size(366, 25);
            this.ComponentSubType.TabIndex = 39;
            this.ComponentSubType.TextFieldText = "";
            // 
            // ComponentType
            // 
            this.ComponentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComponentType.LabelText = "ComponentType";
            this.ComponentType.Location = new System.Drawing.Point(3, 141);
            this.ComponentType.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ComponentType.MaximumSize = new System.Drawing.Size(0, 25);
            this.ComponentType.MinimumSize = new System.Drawing.Size(300, 25);
            this.ComponentType.Name = "ComponentType";
            this.ComponentType.Size = new System.Drawing.Size(366, 25);
            this.ComponentType.TabIndex = 38;
            this.ComponentType.TextFieldText = "";
            // 
            // CriticalComponent
            // 
            this.CriticalComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CriticalComponent.LabelText = "CriticalComponent";
            this.CriticalComponent.Location = new System.Drawing.Point(3, 116);
            this.CriticalComponent.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CriticalComponent.MaximumSize = new System.Drawing.Size(0, 25);
            this.CriticalComponent.MinimumSize = new System.Drawing.Size(300, 25);
            this.CriticalComponent.Name = "CriticalComponent";
            this.CriticalComponent.Size = new System.Drawing.Size(366, 25);
            this.CriticalComponent.TabIndex = 37;
            this.CriticalComponent.TextFieldText = "";
            // 
            // DisallowedLocations
            // 
            this.DisallowedLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisallowedLocations.LabelText = "DisallowedLocations";
            this.DisallowedLocations.Location = new System.Drawing.Point(3, 91);
            this.DisallowedLocations.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DisallowedLocations.MaximumSize = new System.Drawing.Size(0, 25);
            this.DisallowedLocations.MinimumSize = new System.Drawing.Size(300, 25);
            this.DisallowedLocations.Name = "DisallowedLocations";
            this.DisallowedLocations.Size = new System.Drawing.Size(366, 25);
            this.DisallowedLocations.TabIndex = 36;
            this.DisallowedLocations.TextFieldText = "";
            // 
            // AllowedLocations
            // 
            this.AllowedLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllowedLocations.LabelText = "AllowedLocations";
            this.AllowedLocations.Location = new System.Drawing.Point(3, 66);
            this.AllowedLocations.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AllowedLocations.MaximumSize = new System.Drawing.Size(0, 25);
            this.AllowedLocations.MinimumSize = new System.Drawing.Size(300, 25);
            this.AllowedLocations.Name = "AllowedLocations";
            this.AllowedLocations.Size = new System.Drawing.Size(366, 25);
            this.AllowedLocations.TabIndex = 35;
            this.AllowedLocations.TextFieldText = "";
            // 
            // Tonnage
            // 
            this.Tonnage.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tonnage.LabelText = "Tonnage";
            this.Tonnage.Location = new System.Drawing.Point(3, 41);
            this.Tonnage.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Tonnage.MaximumSize = new System.Drawing.Size(0, 25);
            this.Tonnage.MinimumSize = new System.Drawing.Size(300, 25);
            this.Tonnage.Name = "Tonnage";
            this.Tonnage.Size = new System.Drawing.Size(366, 25);
            this.Tonnage.TabIndex = 34;
            this.Tonnage.TextFieldText = "";
            // 
            // InventorySize
            // 
            this.InventorySize.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventorySize.LabelText = "InventorySize";
            this.InventorySize.Location = new System.Drawing.Point(3, 16);
            this.InventorySize.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.InventorySize.MaximumSize = new System.Drawing.Size(0, 25);
            this.InventorySize.MinimumSize = new System.Drawing.Size(300, 25);
            this.InventorySize.Name = "InventorySize";
            this.InventorySize.Size = new System.Drawing.Size(366, 25);
            this.InventorySize.TabIndex = 33;
            this.InventorySize.TextFieldText = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.statusEffects);
            this.groupBox6.Location = new System.Drawing.Point(27, 619);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1134, 100);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Special Effects";
            // 
            // statusEffects
            // 
            this.statusEffects.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusEffects.LabelText = "statusEffects";
            this.statusEffects.Location = new System.Drawing.Point(3, 16);
            this.statusEffects.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.statusEffects.MaximumSize = new System.Drawing.Size(0, 25);
            this.statusEffects.MinimumSize = new System.Drawing.Size(400, 25);
            this.statusEffects.Name = "statusEffects";
            this.statusEffects.Size = new System.Drawing.Size(1128, 25);
            this.statusEffects.TabIndex = 38;
            this.statusEffects.TextFieldText = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BonusValueB);
            this.groupBox7.Controls.Add(this.BonusValueA);
            this.groupBox7.Location = new System.Drawing.Point(802, 127);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(356, 481);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Description";
            // 
            // BonusValueB
            // 
            this.BonusValueB.Dock = System.Windows.Forms.DockStyle.Top;
            this.BonusValueB.LabelText = "BonusValueB";
            this.BonusValueB.Location = new System.Drawing.Point(3, 41);
            this.BonusValueB.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BonusValueB.MaximumSize = new System.Drawing.Size(0, 25);
            this.BonusValueB.MinimumSize = new System.Drawing.Size(300, 25);
            this.BonusValueB.Name = "BonusValueB";
            this.BonusValueB.Size = new System.Drawing.Size(350, 25);
            this.BonusValueB.TabIndex = 28;
            this.BonusValueB.TextFieldText = "";
            // 
            // BonusValueA
            // 
            this.BonusValueA.Dock = System.Windows.Forms.DockStyle.Top;
            this.BonusValueA.LabelText = "BonusValueA";
            this.BonusValueA.Location = new System.Drawing.Point(3, 16);
            this.BonusValueA.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BonusValueA.MaximumSize = new System.Drawing.Size(0, 25);
            this.BonusValueA.MinimumSize = new System.Drawing.Size(300, 25);
            this.BonusValueA.Name = "BonusValueA";
            this.BonusValueA.Size = new System.Drawing.Size(350, 25);
            this.BonusValueA.TabIndex = 27;
            this.BonusValueA.TextFieldText = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BattleValue);
            this.groupBox8.Controls.Add(this.PrefabIdentifier);
            this.groupBox8.Location = new System.Drawing.Point(24, 725);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1131, 100);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Other Values";
            // 
            // BattleValue
            // 
            this.BattleValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.BattleValue.LabelText = "BattleValue";
            this.BattleValue.Location = new System.Drawing.Point(3, 41);
            this.BattleValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BattleValue.MaximumSize = new System.Drawing.Size(0, 25);
            this.BattleValue.MinimumSize = new System.Drawing.Size(400, 25);
            this.BattleValue.Name = "BattleValue";
            this.BattleValue.Size = new System.Drawing.Size(1125, 25);
            this.BattleValue.TabIndex = 32;
            this.BattleValue.TextFieldText = "";
            // 
            // PrefabIdentifier
            // 
            this.PrefabIdentifier.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrefabIdentifier.LabelText = "PrefabIdentifier";
            this.PrefabIdentifier.Location = new System.Drawing.Point(3, 16);
            this.PrefabIdentifier.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PrefabIdentifier.MaximumSize = new System.Drawing.Size(0, 25);
            this.PrefabIdentifier.MinimumSize = new System.Drawing.Size(400, 25);
            this.PrefabIdentifier.Name = "PrefabIdentifier";
            this.PrefabIdentifier.Size = new System.Drawing.Size(1125, 25);
            this.PrefabIdentifier.TabIndex = 31;
            this.PrefabIdentifier.TextFieldText = "";
            // 
            // WeaponDesignerControlSet
            // 
            this.AutoScroll = true;
            this.BackgroundImage = global::MechForge.Properties.Resources.ac5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "WeaponDesignerControlSet";
            this.Size = new System.Drawing.Size(1175, 840);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textField4_Load(object sender, System.EventArgs e)
        {

        }

        private void textField16_Load(object sender, System.EventArgs e)
        {

        }

        private void textField19_Load(object sender, System.EventArgs e)
        {

        }

        private void textField18_Load(object sender, System.EventArgs e)
        {

        }

        private void textField31_Load(object sender, System.EventArgs e)
        {

        }

        private void textField26_Load(object sender, System.EventArgs e)
        {

        }

        private void textField2_Load(object sender, System.EventArgs e)
        {

        }

        private void textField29_Load(object sender, System.EventArgs e)
        {

        }

        private void textField28_Load(object sender, System.EventArgs e)
        {

        }

        private void textField12_Load(object sender, System.EventArgs e)
        {

        }

        private void textField7_Load(object sender, System.EventArgs e)
        {

        }

        private void textField15_Load(object sender, System.EventArgs e)
        {

        }

        private void textField14_Load(object sender, System.EventArgs e)
        {

        }

        private void textField17_Load(object sender, System.EventArgs e)
        {

        }

        private void textField22_Load(object sender, System.EventArgs e)
        {

        }

        private void textField8_Load(object sender, System.EventArgs e)
        {

        }

        private void textField25_Load(object sender, System.EventArgs e)
        {

        }

        private void textField24_Load(object sender, System.EventArgs e)
        {

        }

        private void textField27_Load(object sender, System.EventArgs e)
        {

        }

        private void textField11_Load(object sender, System.EventArgs e)
        {

        }

        private void textField10_Load(object sender, System.EventArgs e)
        {

        }

        private void textField13_Load(object sender, System.EventArgs e)
        {

        }

        private void textField21_Load(object sender, System.EventArgs e)
        {

        }

        private void textField20_Load(object sender, System.EventArgs e)
        {

        }

        private void textField5_Load(object sender, System.EventArgs e)
        {

        }

        private void textField23_Load(object sender, System.EventArgs e)
        {

        }

        private void textField6_Load(object sender, System.EventArgs e)
        {

        }

        private void textField30_Load(object sender, System.EventArgs e)
        {

        }

        private void textField33_Load(object sender, System.EventArgs e)
        {

        }

        private void textField36_Load(object sender, System.EventArgs e)
        {

        }

        private void textField3_Load(object sender, System.EventArgs e)
        {

        }

        private void textField1_Load(object sender, System.EventArgs e)
        {

        }

        private void textField32_Load(object sender, System.EventArgs e)
        {

        }

        private void textField9_Load(object sender, System.EventArgs e)
        {

        }

        private void textField35_Load(object sender, System.EventArgs e)
        {

        }

        private void textField34_Load(object sender, System.EventArgs e)
        {

        }

        private void textField37_Load(object sender, System.EventArgs e)
        {

        }
    }
}