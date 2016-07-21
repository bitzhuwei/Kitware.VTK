using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUGFacetReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUGFacetReader";

		public new static readonly string MRClassNameKey;

		static vtkUGFacetReader()
		{
			vtkUGFacetReader.MRClassNameKey = "class vtkUGFacetReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUGFacetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUGFacetReader"));
		}

		public vtkUGFacetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUGFacetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUGFacetReader New()
		{
			vtkUGFacetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUGFacetReader.vtkUGFacetReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUGFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUGFacetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUGFacetReader.vtkUGFacetReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkUGFacetReader.vtkUGFacetReader_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUGFacetReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkUGFacetReader.vtkUGFacetReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUGFacetReader_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUGFacetReader.vtkUGFacetReader_GetLocator_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkUGFacetReader_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkUGFacetReader.vtkUGFacetReader_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUGFacetReader_GetMerging_05(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkUGFacetReader.vtkUGFacetReader_GetMerging_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUGFacetReader_GetNumberOfParts_06(HandleRef pThis);

		public int GetNumberOfParts()
		{
			return vtkUGFacetReader.vtkUGFacetReader_GetNumberOfParts_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern short vtkUGFacetReader_GetPartColorIndex_07(HandleRef pThis, int partId);

		public short GetPartColorIndex(int partId)
		{
			return vtkUGFacetReader.vtkUGFacetReader_GetPartColorIndex_07(base.GetCppThis(), partId);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUGFacetReader_GetPartNumber_08(HandleRef pThis);

		public virtual int GetPartNumber()
		{
			return vtkUGFacetReader.vtkUGFacetReader_GetPartNumber_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUGFacetReader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUGFacetReader.vtkUGFacetReader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUGFacetReader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUGFacetReader.vtkUGFacetReader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_MergingOff_11(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkUGFacetReader.vtkUGFacetReader_MergingOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_MergingOn_12(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkUGFacetReader.vtkUGFacetReader_MergingOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUGFacetReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUGFacetReader NewInstance()
		{
			vtkUGFacetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUGFacetReader.vtkUGFacetReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUGFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUGFacetReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUGFacetReader SafeDownCast(vtkObjectBase o)
		{
			vtkUGFacetReader vtkUGFacetReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUGFacetReader.vtkUGFacetReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUGFacetReader = (vtkUGFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUGFacetReader.Register(null);
				}
			}
			return vtkUGFacetReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_SetFileName_16(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkUGFacetReader.vtkUGFacetReader_SetFileName_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_SetLocator_17(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkUGFacetReader.vtkUGFacetReader_SetLocator_17(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_SetMerging_18(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkUGFacetReader.vtkUGFacetReader_SetMerging_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUGFacetReader_SetPartNumber_19(HandleRef pThis, int _arg);

		public virtual void SetPartNumber(int _arg)
		{
			vtkUGFacetReader.vtkUGFacetReader_SetPartNumber_19(base.GetCppThis(), _arg);
		}
	}
}
