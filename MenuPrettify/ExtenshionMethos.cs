namespace MenuPrettify
{
    public static class ExtenshionMethos
    {
        public static int CorrectSeparators(this ToolStripItemCollection items)
        {
            int shownItems = 0;
            ToolStripItem? lastItem = null;

            foreach (ToolStripItem i in items)
            {
                //if (i.Name == "TestItem")
                //{
                //    MessageBox.Show(i.Visible.ToString() + "2");
                //}

                if (!i.Available)
                    continue;

                //MessageBox.Show(shownItems.ToString());
                    
                if (lastItem == null && i is ToolStripSeparator)
                {
                    /// Отключаем, если сепаратор оказался первым
                    i.Visible = false;
                }
                else if (lastItem is ToolStripSeparator && i is ToolStripSeparator)
                {
                    /// Отключаем двойные сепараторы
                    i.Visible = false;
                }
                else if (i is ToolStripDropDownItem d && d.HasDropDownItems)
                {
                    /// Циклично для вложенных пунктов. Собственно, этот
                    /// фрагмент не позволил сходу сделать данный метод
                    /// методом расширения для ToolStripMenu
                    var cnt = CorrectSeparators(d.DropDownItems);

                    /// Скроем пункт меню, если он не содержит вложения
                    if (cnt == 0)
                    {
                        i.Visible = false;
                    }
                }
                else
                {
                    shownItems++;
                }

                lastItem = i;
            }

            if (lastItem is ToolStripSeparator _)
            {
                //MessageBox.Show(lastItem.Text + " ");
                lastItem.Visible = false;
            }

            return shownItems;

            //if (visibles.Count > 0)
            //{
            //    if (visibles[0] is ToolStripSeparator firstSep)
            //    {
            //        firstSep.Visible = false;
            //    }

            //    if (visibles.Count > 1 && visibles[visibles.Count - 1] is ToolStripSeparator lastSep)
            //    {
            //        lastSep.Visible = false;
            //    }
            //}

            //if (items.Count == 0)
            //    return;

            //ToolStripItem? prevItem = null;
            ///// Флаг указывает, является ли предыдущий пункт сепаратором.
            ///// Для удаления двойных сепараторов
            //bool prevSeparator = false;



            //foreach (ToolStripItem i in items)
            //{
            //    /// В рамках этого корректора все не доступные пункты
            //    /// окажутся скрытыми
            //    //i.Visible = i.Enabled;
            //    if (!i.Visible)
            //        continue;

            //    if (i is ToolStripSeparator)
            //    {
            //        if (prevItem == null || prevSeparator)
            //        {
            //            /// Отключаем, если перед сепаратором ничего нет,
            //            /// либо там тоже сепаратор
            //            i.Visible = false;
            //            continue;
            //        }

            //        prevSeparator = true;
            //    }
            //    else
            //    {
            //        prevSeparator = false;
            //    }

            //    if (i is ToolStripDropDownItem d)
            //    {
            //        /// Циклично для вложенных пунктов. Собственно, этот
            //        /// фрагмент не позволил сходу сделать данный метод
            //        /// методом расширения для ToolStripMenu
            //        CorrectSeparators(d.DropDownItems);
            //    }


            //    prevItem = i;
            //    lastItem = i;
            //}

            //if (prevItem != null && prevSeparator)
            //{
            //    prevItem.Visible = false;
            //}

            ///// Избавляемя от висячего сепаратора
            //if (lastItem is ToolStripSeparator sep)
            //{
            //    sep.Visible = false;
            //}
        }
    }
}
