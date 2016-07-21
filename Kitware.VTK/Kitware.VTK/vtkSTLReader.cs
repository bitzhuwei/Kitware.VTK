using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSTLReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSTLReader";

		public new static readonly string MRClassNameKey;

		static vtkSTLReader()
		{
			vtkSTLReader.MRClassNameKey = "class vtkSTLReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSTLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSTLReader"));
		}

		public vtkSTLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSTLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSTLReader New()
		{
			vtkSTLReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSTLReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSTLReader.vtkSTLReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkSTLReader.vtkSTLReader_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSTLReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSTLReader.vtkSTLReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSTLReader_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_GetLocator_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkSTLReader_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSTLReader.vtkSTLReader_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSTLReader_GetMerging_05(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkSTLReader.vtkSTLReader_GetMerging_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSTLReader_GetScalarTags_06(HandleRef pThis);

		public virtual int GetScalarTags()
		{
			return vtkSTLReader.vtkSTLReader_GetScalarTags_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSTLReader_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSTLReader.vtkSTLReader_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSTLReader_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSTLReader.vtkSTLReader_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_MergingOff_09(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkSTLReader.vtkSTLReader_MergingOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_MergingOn_10(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkSTLReader.vtkSTLReader_MergingOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSTLReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSTLReader NewInstance()
		{
			vtkSTLReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSTLReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSTLReader SafeDownCast(vtkObjectBase o)
		{
			vtkSTLReader vtkSTLReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSTLReader = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSTLReader.Register(null);
				}
			}
			return vtkSTLReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_ScalarTagsOff_14(HandleRef pThis);

		public virtual void ScalarTagsOff()
		{
			vtkSTLReader.vtkSTLReader_ScalarTagsOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_ScalarTagsOn_15(HandleRef pThis);

		public virtual void ScalarTagsOn()
		{
			vtkSTLReader.vtkSTLReader_ScalarTagsOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_SetFileName_16(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkSTLReader.vtkSTLReader_SetFileName_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_SetLocator_17(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkSTLReader.vtkSTLReader_SetLocator_17(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_SetMerging_18(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkSTLReader.vtkSTLReader_SetMerging_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSTLReader_SetScalarTags_19(HandleRef pThis, int _arg);

		public virtual void SetScalarTags(int _arg)
		{
			vtkSTLReader.vtkSTLReader_SetScalarTags_19(base.GetCppThis(), _arg);
		}
	}
}
