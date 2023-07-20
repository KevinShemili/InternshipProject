namespace InternshipProject.Objects.Requests.RolePermissionRequests {
    public class AssignationRequest {
        public List<Guid> AssignIds { get; set; } = null!;
        public List<Guid> UnassignIds { get; set; } = null!;

    }
}
