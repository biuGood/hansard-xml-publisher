document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.getElementById("searchInput");
    const table = document.getElementById("transcriptTable");
    const rows = table.getElementsByTagName("tr");

    searchInput.addEventListener("keyup", function () {
        const searchText = searchInput.value.toLowerCase();

        for (let i = 1; i < rows.length; i++) {
            const rowText = rows[i].innerText.toLowerCase();

            if (rowText.includes(searchText)) {
                rows[i].style.display = "";
            } else {
                rows[i].style.display = "none";
            }
        }
    });
});