


### Create User With Password:

###### Way 1:
	IdentityUser applicationUser = new IdentityUser();
	Guid guid = Guid.NewGuid();
	applicationUser.Id = guid.ToString();
	applicationUser.UserName = "Joe";
	applicationUser.Email = "wx@hotmail.com";
	applicationUser.NormalizedUserName = "wx@hotmail.com";

	_context.Users.Add(applicationUser);


	var hashedPassword = _passwordHasher.HashPassword(applicationUser, "YourPassword");
	applicationUser.SecurityStamp = Guid.NewGuid().ToString();
	applicationUser.PasswordHash = hashedPassword;

	_context.SaveChanges();



###### Way 2:
	var user = new IdentityUser { UserName = "Joe", Email = "wx@hotmail.com" };
	var result = await _userManager.CreateAsync(user, "YourPassWord");
	if (result.Succeeded)
	{

	}