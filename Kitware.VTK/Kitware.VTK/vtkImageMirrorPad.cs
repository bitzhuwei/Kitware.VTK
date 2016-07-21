using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMirrorPad : vtkImagePadFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMirrorPad";

		public new static readonly string MRClassNameKey;

		static vtkImageMirrorPad()
		{
			vtkImageMirrorPad.MRClassNameKey = "class vtkImageMirrorPad";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMirrorPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMirrorPad"));
		}

		public vtkImageMirrorPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMirrorPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMirrorPad New()
		{
			vtkImageMirrorPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMirrorPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMirrorPad.vtkImageMirrorPad_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMirrorPad_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMirrorPad_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMirrorPad_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMirrorPad NewInstance()
		{
			vtkImageMirrorPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMirrorPad_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMirrorPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageMirrorPad vtkImageMirrorPad = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMirrorPad = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMirrorPad.Register(null);
				}
			}
			return vtkImageMirrorPad;
		}
	}
}
