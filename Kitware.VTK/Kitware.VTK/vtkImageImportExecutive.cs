using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageImportExecutive : vtkStreamingDemandDrivenPipeline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageImportExecutive";

		public new static readonly string MRClassNameKey;

		static vtkImageImportExecutive()
		{
			vtkImageImportExecutive.MRClassNameKey = "class vtkImageImportExecutive";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageImportExecutive.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageImportExecutive"));
		}

		public vtkImageImportExecutive(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImportExecutive_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageImportExecutive New()
		{
			vtkImageImportExecutive result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageImportExecutive() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageImportExecutive.vtkImageImportExecutive_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImportExecutive_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageImportExecutive_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImportExecutive_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageImportExecutive NewInstance()
		{
			vtkImageImportExecutive result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageImportExecutive_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageImportExecutive SafeDownCast(vtkObjectBase o)
		{
			vtkImageImportExecutive vtkImageImportExecutive = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageImportExecutive = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageImportExecutive.Register(null);
				}
			}
			return vtkImageImportExecutive;
		}
	}
}
