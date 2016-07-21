using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimpleImageFilterExample : vtkSimpleImageToImageFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleImageFilterExample";

		public new static readonly string MRClassNameKey;

		static vtkSimpleImageFilterExample()
		{
			vtkSimpleImageFilterExample.MRClassNameKey = "class vtkSimpleImageFilterExample";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleImageFilterExample.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleImageFilterExample"));
		}

		public vtkSimpleImageFilterExample(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleImageFilterExample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleImageFilterExample New()
		{
			vtkSimpleImageFilterExample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleImageFilterExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimpleImageFilterExample() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSimpleImageFilterExample_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSimpleImageFilterExample_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleImageFilterExample_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimpleImageFilterExample NewInstance()
		{
			vtkSimpleImageFilterExample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleImageFilterExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleImageFilterExample_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleImageFilterExample SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleImageFilterExample vtkSimpleImageFilterExample = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleImageFilterExample.vtkSimpleImageFilterExample_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleImageFilterExample = (vtkSimpleImageFilterExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleImageFilterExample.Register(null);
				}
			}
			return vtkSimpleImageFilterExample;
		}
	}
}
