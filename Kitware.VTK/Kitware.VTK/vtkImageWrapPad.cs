using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageWrapPad : vtkImagePadFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWrapPad";

		public new static readonly string MRClassNameKey;

		static vtkImageWrapPad()
		{
			vtkImageWrapPad.MRClassNameKey = "class vtkImageWrapPad";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWrapPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWrapPad"));
		}

		public vtkImageWrapPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWrapPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWrapPad New()
		{
			vtkImageWrapPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageWrapPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageWrapPad.vtkImageWrapPad_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWrapPad_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWrapPad_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWrapPad_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageWrapPad NewInstance()
		{
			vtkImageWrapPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWrapPad_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWrapPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageWrapPad vtkImageWrapPad = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWrapPad = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWrapPad.Register(null);
				}
			}
			return vtkImageWrapPad;
		}
	}
}
