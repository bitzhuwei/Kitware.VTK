using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPExodusIIReader : vtkExodusIIReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExodusIIReader";

		public new static readonly string MRClassNameKey;

		static vtkPExodusIIReader()
		{
			vtkPExodusIIReader.MRClassNameKey = "class vtkPExodusIIReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExodusIIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExodusIIReader"));
		}

		public vtkPExodusIIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExodusIIReader New()
		{
			vtkPExodusIIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusIIReader.vtkPExodusIIReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPExodusIIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPExodusIIReader.vtkPExodusIIReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_Broadcast_01(HandleRef pThis, HandleRef ctrl);

		public virtual void Broadcast(vtkMultiProcessController ctrl)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_Broadcast_01(base.GetCppThis(), (ctrl == null) ? default(HandleRef) : ctrl.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusIIReader.vtkPExodusIIReader_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_GetFilePattern_03(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkPExodusIIReader.vtkPExodusIIReader_GetFilePattern_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_GetFilePrefix_04(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkPExodusIIReader.vtkPExodusIIReader_GetFilePrefix_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_GetFileRange_05(HandleRef pThis);

		public virtual int[] GetFileRange()
		{
			IntPtr intPtr = vtkPExodusIIReader.vtkPExodusIIReader_GetFileRange_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_GetFileRange_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetFileRange(ref int _arg1, ref int _arg2)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_GetFileRange_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_GetFileRange_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetFileRange(IntPtr _arg)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_GetFileRange_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusIIReader_GetNumberOfFileNames_08(HandleRef pThis);

		public int GetNumberOfFileNames()
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_GetNumberOfFileNames_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusIIReader_GetNumberOfFiles_09(HandleRef pThis);

		public virtual int GetNumberOfFiles()
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_GetNumberOfFiles_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkPExodusIIReader_GetTotalNumberOfElements_10(HandleRef pThis);

		public override long GetTotalNumberOfElements()
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_GetTotalNumberOfElements_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkPExodusIIReader_GetTotalNumberOfNodes_11(HandleRef pThis);

		public override long GetTotalNumberOfNodes()
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_GetTotalNumberOfNodes_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusIIReader_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusIIReader_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPExodusIIReader.vtkPExodusIIReader_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPExodusIIReader NewInstance()
		{
			vtkPExodusIIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusIIReader.vtkPExodusIIReader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusIIReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExodusIIReader SafeDownCast(vtkObjectBase o)
		{
			vtkPExodusIIReader vtkPExodusIIReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusIIReader.vtkPExodusIIReader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExodusIIReader = (vtkPExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExodusIIReader.Register(null);
				}
			}
			return vtkPExodusIIReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetController_17(HandleRef pThis, HandleRef c);

		public void SetController(vtkMultiProcessController c)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetController_17(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetFileName_18(HandleRef pThis, string name);

		public override void SetFileName(string name)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetFileName_18(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetFilePattern_19(HandleRef pThis, string _arg);

		public virtual void SetFilePattern(string _arg)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetFilePattern_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetFilePrefix_20(HandleRef pThis, string _arg);

		public virtual void SetFilePrefix(string _arg)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetFilePrefix_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetFileRange_21(HandleRef pThis, int arg0, int arg1);

		public void SetFileRange(int arg0, int arg1)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetFileRange_21(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_SetFileRange_22(HandleRef pThis, IntPtr r);

		public void SetFileRange(IntPtr r)
		{
			vtkPExodusIIReader.vtkPExodusIIReader_SetFileRange_22(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusIIReader_UpdateTimeInformation_23(HandleRef pThis);

		public override void UpdateTimeInformation()
		{
			vtkPExodusIIReader.vtkPExodusIIReader_UpdateTimeInformation_23(base.GetCppThis());
		}
	}
}
