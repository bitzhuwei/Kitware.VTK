using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEllipsoidTensorProbeRepresentation : vtkTensorProbeRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipsoidTensorProbeRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkEllipsoidTensorProbeRepresentation()
		{
			vtkEllipsoidTensorProbeRepresentation.MRClassNameKey = "class vtkEllipsoidTensorProbeRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipsoidTensorProbeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipsoidTensorProbeRepresentation"));
		}

		public vtkEllipsoidTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEllipsoidTensorProbeRepresentation New()
		{
			vtkEllipsoidTensorProbeRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEllipsoidTensorProbeRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEllipsoidTensorProbeRepresentation NewInstance()
		{
			vtkEllipsoidTensorProbeRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_08(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEllipsoidTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkEllipsoidTensorProbeRepresentation vtkEllipsoidTensorProbeRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipsoidTensorProbeRepresentation = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipsoidTensorProbeRepresentation.Register(null);
				}
			}
			return vtkEllipsoidTensorProbeRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_SelectProbe_10(HandleRef pThis, IntPtr pos);

		public override int SelectProbe(IntPtr pos)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_SelectProbe_10(base.GetCppThis(), pos);
		}
	}
}
