﻿using System.Linq;
using FluentAssertions;
using GitUI;

namespace GitExtUtilsTests
{
    [TestFixture]
    public class ComboBoxExtensionsTests
    {
        [Test]
        public void AdjustWidthToFitContent_should_throw_if_combo_null()
        {
            ((Action)(() => ((ComboBox)null).AdjustWidthToFitContent())).Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ResizeDropDownWidth_ComboBox_should_throw_if_combo_null()
        {
            ((Action)(() => ((ComboBox)null).ResizeDropDownWidth(1, 2))).Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_should_throw_if_combo_null()
        {
            ((Action)(() => ((ToolStripComboBox)null).ResizeDropDownWidth(1, 2))).Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Sets_Width_To_A_Minimum_When_Its_Higher_Than_Content_Width()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ToolStripComboBox comboBox = new();
            comboBox.Items.Add(veryLongString);

            // Act
            comboBox.ResizeDropDownWidth(4000, 5000);

            // Assert
            comboBox.DropDownWidth.Should().Be(4000);
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Caps_At_Maximum_When_Item_Too_Long()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ToolStripComboBox comboBox = new();
            comboBox.Items.Add(veryLongString);

            // Act
            comboBox.ResizeDropDownWidth(1, 400);

            // Assert
            comboBox.DropDownWidth.Should().Be(400);
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Respects_DisplayMember()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ComboBox comboBox = new();
            comboBox.DisplayMember = "Value";
            comboBox.Items.Add(new ComboBoxItem(Value: veryLongString, ToStringValue: ""));

            // Act
            comboBox.ResizeDropDownWidth(1, 400);

            // Assert
            comboBox.DropDownWidth.Should().Be(400);
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Respects_DisplayMember_When_Value_Is_Null()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ComboBox comboBox = new();
            comboBox.DisplayMember = "Value";
            comboBox.Items.Add(new ComboBoxItem(Value: null, ToStringValue: veryLongString));

            // Act
            comboBox.ResizeDropDownWidth(1, 400);

            // Assert
            comboBox.DropDownWidth.Should().BeLessThan(400);
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Uses_ToString_Value()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ComboBox comboBox = new();
            comboBox.Items.Add(new ComboBoxItem(Value: "", ToStringValue: veryLongString));

            // Act
            comboBox.ResizeDropDownWidth(1, 400);

            // Assert
            comboBox.DropDownWidth.Should().Be(400);
        }

        [Test]
        public void ResizeDropDownWidth_ToolStripComboBox_Uses_ToString_Value_When_DisplayMember_Is_Not_On_Item()
        {
            // Arrange
            string veryLongString = string.Join(", ", Enumerable.Repeat("A very long string", 20));

            ComboBox comboBox = new();
            comboBox.DisplayMember = "NonExistentMemberName";
            comboBox.Items.Add(new ComboBoxItem(Value: "", ToStringValue: veryLongString));

            // Act
            comboBox.ResizeDropDownWidth(1, 400);

            // Assert
            comboBox.DropDownWidth.Should().Be(400);
        }

        private record ComboBoxItem(string? Value, string ToStringValue)
        {
            public override string ToString() => ToStringValue;
        }
    }
}
