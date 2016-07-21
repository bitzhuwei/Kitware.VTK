using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGAMBITReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGAMBITReader";

		public new static readonly string MRClassNameKey;

		static vtkGAMBITReader()
		{
			vtkGAMBITReader.MRClassNameKey = "class vtkGAMBITReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGAMBITReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGAMBITReader"));
		}

		public vtkGAMBITReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGAMBITReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGAMBITReader New()
		{
			vtkGAMBITReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGAMBITReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGAMBITReader.vtkGAMBITReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGAMBITReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkGAMBITReader.vtkGAMBITReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_GetNumberOfCellFields_02(HandleRef pThis);

		public virtual int GetNumberOfCellFields()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfCellFields_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_GetNumberOfCells_03(HandleRef pThis);

		public virtual int GetNumberOfCells()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfCells_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_GetNumberOfNodeFields_04(HandleRef pThis);

		public virtual int GetNumberOfNodeFields()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfNodeFields_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_GetNumberOfNodes_05(HandleRef pThis);

		public virtual int GetNumberOfNodes()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfNodes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGAMBITReader_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGAMBITReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGAMBITReader NewInstance()
		{
			vtkGAMBITReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGAMBITReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGAMBITReader SafeDownCast(vtkObjectBase o)
		{
			vtkGAMBITReader vtkGAMBITReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGAMBITReader = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGAMBITReader.Register(null);
				}
			}
			return vtkGAMBITReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGAMBITReader_SetFileName_11(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkGAMBITReader.vtkGAMBITReader_SetFileName_11(base.GetCppThis(), _arg);
		}
	}
}
