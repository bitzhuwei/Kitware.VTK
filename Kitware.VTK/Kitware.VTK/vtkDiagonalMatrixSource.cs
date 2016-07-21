using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDiagonalMatrixSource : vtkArrayDataAlgorithm
	{
		public enum StorageType
		{
			DENSE,
			SPARSE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDiagonalMatrixSource";

		public new static readonly string MRClassNameKey;

		static vtkDiagonalMatrixSource()
		{
			vtkDiagonalMatrixSource.MRClassNameKey = "class vtkDiagonalMatrixSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiagonalMatrixSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiagonalMatrixSource"));
		}

		public vtkDiagonalMatrixSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDiagonalMatrixSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiagonalMatrixSource New()
		{
			vtkDiagonalMatrixSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDiagonalMatrixSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDiagonalMatrixSource_GetArrayType_01(HandleRef pThis);

		public virtual int GetArrayType()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetArrayType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDiagonalMatrixSource_GetColumnLabel_02(HandleRef pThis);

		public virtual string GetColumnLabel()
		{
			return Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetColumnLabel_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkDiagonalMatrixSource_GetDiagonal_03(HandleRef pThis);

		public virtual double GetDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetDiagonal_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkDiagonalMatrixSource_GetExtents_04(HandleRef pThis);

		public virtual long GetExtents()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetExtents_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDiagonalMatrixSource_GetRowLabel_05(HandleRef pThis);

		public virtual string GetRowLabel()
		{
			return Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetRowLabel_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkDiagonalMatrixSource_GetSubDiagonal_06(HandleRef pThis);

		public virtual double GetSubDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetSubDiagonal_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkDiagonalMatrixSource_GetSuperDiagonal_07(HandleRef pThis);

		public virtual double GetSuperDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetSuperDiagonal_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDiagonalMatrixSource_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDiagonalMatrixSource_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDiagonalMatrixSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDiagonalMatrixSource NewInstance()
		{
			vtkDiagonalMatrixSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDiagonalMatrixSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiagonalMatrixSource SafeDownCast(vtkObjectBase o)
		{
			vtkDiagonalMatrixSource vtkDiagonalMatrixSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiagonalMatrixSource = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiagonalMatrixSource.Register(null);
				}
			}
			return vtkDiagonalMatrixSource;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetArrayType_13(HandleRef pThis, int _arg);

		public virtual void SetArrayType(int _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetArrayType_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetColumnLabel_14(HandleRef pThis, string _arg);

		public virtual void SetColumnLabel(string _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetColumnLabel_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetDiagonal_15(HandleRef pThis, double _arg);

		public virtual void SetDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetDiagonal_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetExtents_16(HandleRef pThis, long _arg);

		public virtual void SetExtents(long _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetExtents_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetRowLabel_17(HandleRef pThis, string _arg);

		public virtual void SetRowLabel(string _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetRowLabel_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetSubDiagonal_18(HandleRef pThis, double _arg);

		public virtual void SetSubDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetSubDiagonal_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDiagonalMatrixSource_SetSuperDiagonal_19(HandleRef pThis, double _arg);

		public virtual void SetSuperDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetSuperDiagonal_19(base.GetCppThis(), _arg);
		}
	}
}
