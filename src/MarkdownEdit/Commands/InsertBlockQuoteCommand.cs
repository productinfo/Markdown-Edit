﻿using System.Windows;
using System.Windows.Input;
using MarkdownEdit.Controls;
using MarkdownEdit.Models;

namespace MarkdownEdit.Commands
{
    internal static class InsertBlockQuoteCommand
    {
        public static readonly RoutedCommand Command = new RoutedCommand();

        static InsertBlockQuoteCommand()
        {
            Application.Current.MainWindow.CommandBindings.Add(new CommandBinding(Command, Execute, CanExecute));
        }

        private static void Execute(object sender, ExecutedRoutedEventArgs e)
        {
            var editor = ((MainWindow)sender).Editor;
            EditorUtilities.InsertBlockQuote(editor.EditBox);
        }

        private static void CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var editor = ((MainWindow)sender).Editor;
            e.CanExecute = !editor.EditBox.IsReadOnly;
        }
    }
}