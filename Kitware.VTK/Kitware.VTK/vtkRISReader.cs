using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRISReader : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRISReader";

		public new static readonly string MRClassNameKey;

		static vtkRISReader()
		{
			vtkRISReader.MRClassNameKey = "class vtkRISReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRISReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRISReader"));
		}

		public vtkRISReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRISReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRISReader New()
		{
			vtkRISReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRISReader.vtkRISReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRISReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRISReader.vtkRISReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRISReader_GetDelimiter_01(HandleRef pThis);

		public virtual string GetDelimiter()
		{
			return Marshal.PtrToStringAnsi(vtkRISReader.vtkRISReader_GetDelimiter_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRISReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkRISReader.vtkRISReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRISReader_GetMaxRecords_03(HandleRef pThis);

		public virtual int GetMaxRecords()
		{
			return vtkRISReader.vtkRISReader_GetMaxRecords_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRISReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRISReader.vtkRISReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRISReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRISReader.vtkRISReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRISReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRISReader NewInstance()
		{
			vtkRISReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRISReader.vtkRISReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRISReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRISReader SafeDownCast(vtkObjectBase o)
		{
			vtkRISReader vtkRISReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRISReader.vtkRISReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRISReader = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRISReader.Register(null);
				}
			}
			return vtkRISReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRISReader_SetDelimiter_09(HandleRef pThis, string _arg);

		public virtual void SetDelimiter(string _arg)
		{
			vtkRISReader.vtkRISReader_SetDelimiter_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRISReader_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkRISReader.vtkRISReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRISReader_SetMaxRecords_11(HandleRef pThis, int _arg);

		public virtual void SetMaxRecords(int _arg)
		{
			vtkRISReader.vtkRISReader_SetMaxRecords_11(base.GetCppThis(), _arg);
		}
	}
}
