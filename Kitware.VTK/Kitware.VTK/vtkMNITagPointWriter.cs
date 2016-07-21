using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMNITagPointWriter : vtkDataSetWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITagPointWriter";

		public new static readonly string MRClassNameKey;

		static vtkMNITagPointWriter()
		{
			vtkMNITagPointWriter.MRClassNameKey = "class vtkMNITagPointWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITagPointWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITagPointWriter"));
		}

		public vtkMNITagPointWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITagPointWriter New()
		{
			vtkMNITagPointWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMNITagPointWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMNITagPointWriter.vtkMNITagPointWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetComments_01(HandleRef pThis);

		public virtual string GetComments()
		{
			return Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetComments_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetDescriptiveName_02(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetFileExtensions_03(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetLabelText_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetLabelText()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetLabelText_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkMNITagPointWriter_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetPatientIds_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIntArray GetPatientIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPatientIds_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetPoints_07(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints(int port)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPoints_07(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetPoints_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPoints_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetStructureIds_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIntArray GetStructureIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetStructureIds_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_GetWeights_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDoubleArray GetWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetWeights_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITagPointWriter_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITagPointWriter_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMNITagPointWriter NewInstance()
		{
			vtkMNITagPointWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITagPointWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITagPointWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMNITagPointWriter vtkMNITagPointWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITagPointWriter = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITagPointWriter.Register(null);
				}
			}
			return vtkMNITagPointWriter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetComments_16(HandleRef pThis, string _arg);

		public virtual void SetComments(string _arg)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetComments_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetLabelText_17(HandleRef pThis, HandleRef a);

		public virtual void SetLabelText(vtkStringArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetLabelText_17(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetPatientIds_18(HandleRef pThis, HandleRef a);

		public virtual void SetPatientIds(vtkIntArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPatientIds_18(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetPoints_19(HandleRef pThis, int port, HandleRef points);

		public virtual void SetPoints(int port, vtkPoints points)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPoints_19(base.GetCppThis(), port, (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetPoints_20(HandleRef pThis, HandleRef points);

		public virtual void SetPoints(vtkPoints points)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPoints_20(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetStructureIds_21(HandleRef pThis, HandleRef a);

		public virtual void SetStructureIds(vtkIntArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetStructureIds_21(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITagPointWriter_SetWeights_22(HandleRef pThis, HandleRef a);

		public virtual void SetWeights(vtkDoubleArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetWeights_22(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITagPointWriter_Write_23(HandleRef pThis);

		public override int Write()
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_Write_23(base.GetCppThis());
		}
	}
}
