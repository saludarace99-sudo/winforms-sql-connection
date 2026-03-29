private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            var student = new Student
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
            };
            controller.add(student);
            loadData();
            ClearFields();

            MessageBox.Show("Student added successfully!");
        }
        catch(Exception e)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            var student = new Student
            {
                id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
            };
            controller.update(student);
            loadData();
            ClearFields();

            MessageBox.Show("Student updated successfully!");
        }
        catch(Exception e)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = int.Parse(txtId.Text);

            var confirm = MessageBox.Show(
            "Are you sure you want to delete this student?",
            "Confirm Delete",
            MessageBoxButtons.YesNo
            );

            if(confirm == DialogResult.Yes)
            {
                controller.delete(id);
                loadData();
                ClearFields();

                MessageBox.Show("Student deleted successfully!");
            }
        }
        catch(Exception e)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void dataGridView1_CellClick(object sender, EventArgs e)
    {
        if(e.RowIndex >= 0)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtId.Text = row.Cells["Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtAge.Text = row.Cells["Age"].Value.ToString();
        }
    }
}
