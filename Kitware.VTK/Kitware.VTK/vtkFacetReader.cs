using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFacetReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFacetReader";

		public new static readonly string MRClassNameKey;

		static vtkFacetReader()
		{
			vtkFacetReader.MRClassNameKey = "class vtkFacetReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFacetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFacetReader"));
		}

		public vtkFacetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkFacetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFacetReader New()
		{
			vtkFacetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFacetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFacetReader.vtkFacetReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkFacetReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkFacetReader.vtkFacetReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkFacetReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkFacetReader.vtkFacetReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkFacetReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFacetReader.vtkFacetReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkFacetReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFacetReader.vtkFacetReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkFacetReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFacetReader NewInstance()
		{
			vtkFacetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkFacetReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFacetReader SafeDownCast(vtkObjectBase o)
		{
			vtkFacetReader vtkFacetReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFacetReader = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFacetReader.Register(null);
				}
			}
			return vtkFacetReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkFacetReader_SetFileName_08(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkFacetReader.vtkFacetReader_SetFileName_08(base.GetCppThis(), _arg);
		}
	}
}
