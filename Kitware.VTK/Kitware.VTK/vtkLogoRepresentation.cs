using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLogoRepresentation : vtkBorderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogoRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkLogoRepresentation()
		{
			vtkLogoRepresentation.MRClassNameKey = "class vtkLogoRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogoRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogoRepresentation"));
		}

		public vtkLogoRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogoRepresentation New()
		{
			vtkLogoRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLogoRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLogoRepresentation.vtkLogoRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkLogoRepresentation.vtkLogoRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoRepresentation_GetActors2D_02(HandleRef pThis, HandleRef pc);

		public override void GetActors2D(vtkPropCollection pc)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_GetActors2D_02(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoRepresentation_GetImage_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_GetImage_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoRepresentation_GetImageProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetImageProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_GetImageProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLogoRepresentation_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLogoRepresentation_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLogoRepresentation NewInstance()
		{
			vtkLogoRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoRepresentation_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_ReleaseGraphicsResources_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLogoRepresentation_RenderOverlay_10(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_RenderOverlay_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogoRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkLogoRepresentation vtkLogoRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogoRepresentation = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogoRepresentation.Register(null);
				}
			}
			return vtkLogoRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoRepresentation_SetImage_12(HandleRef pThis, HandleRef img);

		public virtual void SetImage(vtkImageData img)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_SetImage_12(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoRepresentation_SetImageProperty_13(HandleRef pThis, HandleRef p);

		public virtual void SetImageProperty(vtkProperty2D p)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_SetImageProperty_13(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}
	}
}
