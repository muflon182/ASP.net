document.forms[0].onsubmit = () => {
    let formData = new FormData(document.forms[0]);
    let alertEl = document.getElementById('success-alert');
    fetch('', {
        method: 'post',
        body: new URLSearchParams(formData)
    })
        .then(() => {
            alertEl.style.display = 'flex';
        });
    return false;
};

//(function () {
//    const alertEl = document.getElementById("success-alert");
//    const form = document.forms[0];

//    const addNewItem = async () => {
//        const formData = new FormData(form);
//        const requestData = {
//            Name: formData.get("Name"),
//            Description: formData.get("Description"),
//            IsVisible: formData.get("IsVisible") === "true" ? true : false,
//        };

//        alertEl.style.display = "none";

//        const response = await fetch('', {
//            method: "POST",
//            headers: {
//                'Content-Type': 'application/json'
//            },
//            body: JSON.stringify(requestData),
//        });

//        const responseJSON = await response.json();

//        if (responseJSON.success) {
//            alertEl.style.display = "flex";
//        }
//    };

//    window.addEventListener("load", () => {
//        form.addEventListener("submit", event => {
//            event.preventDefault();
//            addNewItem().then(() => console.log("added successfuly"))
//        });
//    });
//})();