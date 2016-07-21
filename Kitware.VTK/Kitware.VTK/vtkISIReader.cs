using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkISIReader : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkISIReader";

		public new static readonly string MRClassNameKey;

		static vtkISIReader()
		{
			vtkISIReader.MRClassNameKey = "class vtkISIReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkISIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkISIReader"));
		}

		public vtkISIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkISIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkISIReader New()
		{
			vtkISIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkISIReader.vtkISIReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkISIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkISIReader.vtkISIReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkISIReader_GetDelimiter_01(HandleRef pThis);

		public virtual string GetDelimiter()
		{
			return Marshal.PtrToStringAnsi(vtkISIReader.vtkISIReader_GetDelimiter_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkISIReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkISIReader.vtkISIReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkISIReader_GetMaxRecords_03(HandleRef pThis);

		public virtual int GetMaxRecords()
		{
			return vtkISIReader.vtkISIReader_GetMaxRecords_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkISIReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkISIReader.vtkISIReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkISIReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkISIReader.vtkISIReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkISIReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkISIReader NewInstance()
		{
			vtkISIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkISIReader.vtkISIReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkISIReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkISIReader SafeDownCast(vtkObjectBase o)
		{
			vtkISIReader vtkISIReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkISIReader.vtkISIReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkISIReader = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkISIReader.Register(null);
				}
			}
			return vtkISIReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkISIReader_SetDelimiter_09(HandleRef pThis, string _arg);

		public virtual void SetDelimiter(string _arg)
		{
			vtkISIReader.vtkISIReader_SetDelimiter_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkISIReader_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkISIReader.vtkISIReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkISIReader_SetMaxRecords_11(HandleRef pThis, int _arg);

		public virtual void SetMaxRecords(int _arg)
		{
			vtkISIReader.vtkISIReader_SetMaxRecords_11(base.GetCppThis(), _arg);
		}
	}
}
