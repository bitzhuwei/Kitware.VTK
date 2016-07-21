using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkFocalPlaneContourRepresentation : vtkContourRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlaneContourRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkFocalPlaneContourRepresentation()
		{
			vtkFocalPlaneContourRepresentation.MRClassNameKey = "class vtkFocalPlaneContourRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFocalPlaneContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlaneContourRepresentation"));
		}

		public vtkFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(HandleRef pThis, int n, int idx, IntPtr point);

		public virtual int GetIntermediatePointDisplayPosition(int n, int idx, IntPtr point)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(base.GetCppThis(), n, idx, point);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(HandleRef pThis, int n, int idx, IntPtr point);

		public override int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(base.GetCppThis(), n, idx, point);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(HandleRef pThis, int n, IntPtr pos);

		public override int GetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(HandleRef pThis, int n, IntPtr pos);

		public override int GetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlaneContourRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFocalPlaneContourRepresentation NewInstance()
		{
			vtkFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlaneContourRepresentation_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkFocalPlaneContourRepresentation vtkFocalPlaneContourRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFocalPlaneContourRepresentation = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFocalPlaneContourRepresentation.Register(null);
				}
			}
			return vtkFocalPlaneContourRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlaneContourRepresentation_UpdateContour_09(HandleRef pThis);

		public virtual int UpdateContour()
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateContour_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_10(HandleRef pThis);

		public virtual void UpdateContourWorldPositionsBasedOnDisplayPositions()
		{
			vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlaneContourRepresentation_UpdateLines_11(HandleRef pThis, int index);

		public virtual void UpdateLines(int index)
		{
			vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateLines_11(base.GetCppThis(), index);
		}
	}
}
